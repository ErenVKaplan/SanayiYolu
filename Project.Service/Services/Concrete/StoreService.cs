using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Data.Entities;
using Project.Data.Enums;
using Project.Data.Migrations;
using Project.Data.UnitOfWorks;
using Project.Data.ViewModels.StoreComments;
using Project.Data.ViewModels.StoreImages;
using Project.Data.ViewModels.Stores;
using Project.Service.Extensions;
using Project.Service.Helpers.Images;
using Project.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Services.Concrete
{
    public class StoreService : IStoreService
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IUnitOfWork unitOfWork;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper imageHelper;

        public StoreService(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.unitOfWork = unitOfWork;
            this.httpContextAccessor = httpContextAccessor;
            this.imageHelper = imageHelper;
        }


        public async Task<ServiceResponse<object>> LoginStoreAsync(StoreLoginViewModel model)
        {
            ServiceResponse<object> response=new ServiceResponse<object>();

            var user = await userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                response.AddErrorMessage("Girdiğiniz Bilgilerle Kayıtlı Kullanıcı Bulunamamıştır");
                return response;
            }

            bool storeAvailable = await unitOfWork.GetRepository<Store>().AnyAsync(x => x.UserId == user.Id);
            if (!storeAvailable)
            {
                response.AddErrorMessage("Girdiğiniz Bilgilerle Kayıtlı Kullanıcı Bulunamamıştır");
                return response;
            }

            var result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

            if (!result.Succeeded)
            {
                response.AddErrorMessage("E-posta ve şifrenizi kontrol ediniz!");
                return response;
            }

            response.AddSuccessMessage("Giriş İşlemi Başarılı!");
            return response;

        }
        public async Task<ServiceResponse<object>> CreateStoreAsync(StoreRegisterViewModel model)
        {
            ServiceResponse<object> response = new ServiceResponse<object>();

            AppUser? user = await userManager.FindByEmailAsync(model.Email);

            // kayıtlı olmayan bir kullanıcı mağaza açmak istiyor. öncelikle kullanıcı hesabı oluşturulmalı.
            if (user == null)
            {
                AppUser newUser = new AppUser
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    UserName = model.Email,
                };

                var result = await userManager.CreateAsync(newUser, model.Password);
                if (result.Succeeded)
                {
                    var userRole = await roleManager.Roles.FirstOrDefaultAsync(x => x.Name == "User");
                    var storeRole = await roleManager.Roles.FirstOrDefaultAsync(x => x.Name == "Store");

                    if (userRole != null)
                    {
                        await userManager.AddToRoleAsync(newUser, userRole.Name!);
                        await userManager.AddToRoleAsync(newUser, storeRole.Name!);

                        Store store = new Store
                        {
                            UserId = newUser.Id,
                            StoreName = model.StoreName,
                            CreatedBy = newUser.Email
                        };

                        Address address = new Address
                        {
                            StoreId = store.Id,
                            AddressName = "",
                            AddressDescription = "",
                            CountryId = model.CountryId,
                            CityId = model.CityId,
                            DistrictId = model.DistrictId,
                            CreatedBy = newUser.Email
                        };


                        await unitOfWork.GetRepository<Store>().AddAsync(store);
                        await unitOfWork.GetRepository<Address>().AddAsync(address);
                        await unitOfWork.SaveAsync();

                        response.AddSuccessMessage("Kayıt İşlemi başarılı!");
                    }
                    else
                        response.AddErrorMessage("User rolü bulunamadı.");

                    return response;
                }
                else
                {
                    foreach (var err in result.Errors)
                        response.AddErrorMessage(err.Description);

                    return response;
                }
            }

            // kullanıcı sistemde kayıtlı. bu kullanıcı ile ilişkili bir store oluşturmak lazım.
            else
            {
                Store store = new Store
                {
                    UserId = user.Id,
                    StoreName = model.StoreName,
                    CreatedBy = model.Email
                };

                Address address = new Address
                {
                    StoreId = store.Id,
                    AddressName = "",
                    AddressDescription = "",
                    CountryId = model.CountryId,
                    CityId = model.CityId,
                    DistrictId = model.DistrictId,
                    CreatedBy = model.Email
                };


                var userRole = await roleManager.Roles.FirstOrDefaultAsync(x => x.Name == "Store");
                await userManager.AddToRoleAsync(user, userRole.Name!);

                await unitOfWork.GetRepository<Store>().AddAsync(store);
                await unitOfWork.GetRepository<Address>().AddAsync(address);
                await unitOfWork.SaveAsync();

                response.AddSuccessMessage("Kayıt İşlemi başarılı!");
                return response;
            }
        }

        public async Task<ServiceResponse<object>> ToggleOnAir()
        {
            ServiceResponse<object> response = new ServiceResponse<object>();

            Guid UserGuid = httpContextAccessor.HttpContext.User.GetLoggedInUserId();
            Store store = await unitOfWork.GetRepository<Store>().GetAsync(x => x.UserId == UserGuid);

            store.OnAir = !store.OnAir;
            await unitOfWork.GetRepository<Store>().UpdateAsync(store);
            await unitOfWork.SaveAsync();

            response.AddSuccessMessage("İşlem başarılı!");
            return response;
        }



        public async Task<List<Store>> GetAllStoresAsync()
        {
            return await unitOfWork.GetRepository<Store>().GetAllAsync(
                predicate: x => !x.IsDeleted && x.OnAir,
                include: source => source
                    .Include(x => x.Address)
                    .ThenInclude(x => x.Country)
                    .Include(x => x.Address)
                    .ThenInclude(x => x.City)
                    .Include(x => x.Address)
                    .ThenInclude(x => x.District)
                    .Include(x => x.Images)
                    .ThenInclude(x => x.Image)
                );
        }
        public async Task<Store> GetStoreDetailsByStoreIdAsync(Guid Id)
        {
            return await unitOfWork.GetRepository<Store>().GetAsync(
                predicate: x => x.Id == Id,
                include: source => source
                    .Include(x => x.Address)
                    .ThenInclude(x => x.Country)
                    .Include(x => x.Address)
                    .ThenInclude(x => x.City)
                    .Include(x => x.Address)
                    .ThenInclude(x => x.District)
                    .Include(x => x.Images)
                    .ThenInclude(x => x.Image)
                    .Include(x => x.Comments)
                    .ThenInclude(x => x.User)
                );
        }
        public async Task<Store> GetStoreDetailsAsync()
        {
            Guid UserGuid = httpContextAccessor.HttpContext.User.GetLoggedInUserId();
            Store store = await unitOfWork.GetRepository<Store>().GetAsync(x => x.UserId == UserGuid);

            return await unitOfWork.GetRepository<Store>().GetAsync(
                predicate: x => x.Id == store.Id,
                include: source => source
                    .Include(x => x.Address)
                    .ThenInclude(x => x.Country)
                    .Include(x => x.Address)
                    .ThenInclude(x => x.City)
                    .Include(x => x.Address)
                    .ThenInclude(x => x.District)
                    .Include(x => x.Images)
                );
        }


        public async Task<List<StoreComment>> GetAllStoreCommentsAsync()
        {
            Guid UserGuid = httpContextAccessor.HttpContext.User.GetLoggedInUserId();

            Store store = await unitOfWork.GetRepository<Store>().GetAsync(x => x.UserId == UserGuid);
            return await unitOfWork.GetRepository<StoreComment>().GetAllAsync(
                predicate: x => x.StoreId == store.Id,
                include: source => source
                    .Include(x => x.User)
                );
        }
        

        public async Task<List<StoreImage>> GetAllStoreImagesAsync()
        {
            Guid UserGuid = httpContextAccessor.HttpContext.User.GetLoggedInUserId();

            Store store = await unitOfWork.GetRepository<Store>().GetAsync(x => x.UserId == UserGuid);
            return await unitOfWork.GetRepository<StoreImage>().GetAllAsync(
                predicate: x => x.StoreId == store.Id,
                include: source => source
                    .Include(x => x.Image)
                );
        }
        public async Task<ServiceResponse<object>> CreateStoreImageAsync(StoreImageCreateViewModel model)
        {
            ServiceResponse<object> response = new ServiceResponse<object>();

            Guid UserGuid = httpContextAccessor.HttpContext.User.GetLoggedInUserId();
            string email = httpContextAccessor.HttpContext.User.GetLoggedInUserEmail();
            
            Store store = await unitOfWork.GetRepository<Store>().GetAsync(x => x.UserId == UserGuid);

            List<Image> storeImages = new List<Image>();
            foreach (var photo in model.Images)
            {
                var imageUpload = await imageHelper.Upload(store.StoreName.ToUpper(), photo, ImageType.StoreImage);
                Image image = new Image { FileName = imageUpload.FullName, FileType = photo.ContentType, CreatedBy = email };
                storeImages.Add(image);
                await unitOfWork.GetRepository<Image>().AddAsync(image);
            }

            foreach (var img in storeImages)
            {
                StoreImage storeImage = new StoreImage()
                {
                    StoreId = store.Id,
                    ImageId = img.Id,
                    CreatedBy = email
                };

                await unitOfWork.GetRepository<StoreImage>().AddAsync(storeImage);
            }

            await unitOfWork.SaveAsync();

            response.AddSuccessMessage("Resim(ler) başarıyla yüklendi!");
            return response;
        }
        public async Task<ServiceResponse<object>> DeleteStoreImageAsync(Guid Id)
        {
            ServiceResponse<object> response = new ServiceResponse<object>();

            StoreImage storeImage = await unitOfWork.GetRepository<StoreImage>().FindAsync(x => x.Id == Id);
            Image image = await unitOfWork.GetRepository<Image>().FindAsync(x => x.Id == storeImage.ImageId);

            await unitOfWork.GetRepository<StoreImage>().DeleteAsync(storeImage);
            await unitOfWork.GetRepository<Image>().DeleteAsync(image);
            await unitOfWork.SaveAsync();

            imageHelper.Delete(image.FileName);

            response.AddSuccessMessage("Resim başarıyla silindi!");
            return response;
        }

        public async Task<ServiceResponse<object>> UpdateStoreDetailsAsync(StoreDetailsViewModel model)
        {
            ServiceResponse<object> response = new ServiceResponse<object>();

            Store store = await unitOfWork.GetRepository<Store>().GetAsync(
                predicate: x => x.Id == model.Id
                );

            store.StoreName = model.StoreName;
            store.StoreDescription = model.StoreDescription;
            store.StoreSlogan = model.StoreSlogan;
            store.CrewSize = model.CrewSize;
            store.OpeningTime = model.OpeningTime;
            store.ClosingTime = model.ClosingTime;

            await unitOfWork.GetRepository<Store>().UpdateAsync(store);
            await unitOfWork.SaveAsync();

            response.AddSuccessMessage("Bilgiler başarıyla güncellendi!");
            return response;
        }
    }
}
