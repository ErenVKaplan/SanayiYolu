using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Data.Entities;
using Project.Data.UnitOfWorks;
using Project.Data.ViewModels.StoreComments;
using Project.Data.ViewModels.Users;
using Project.Service.Extensions;
using Project.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IUnitOfWork unitOfWork;

        public UserService(IMapper mapper, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.httpContextAccessor = httpContextAccessor;
            this.unitOfWork = unitOfWork;
        }

        public async Task<ServiceResponse<object>> LoginUserAsync(UserLoginViewModel model)
        {
            ServiceResponse<object> response = new ServiceResponse<object>();

            var user = await userManager.FindByEmailAsync(model.Email);

            if (user == null)
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
        public async Task<ServiceResponse<object>> CreateUserAsync(UserRegisterViewModel model)
        {
            ServiceResponse<object> response = new ServiceResponse<object>();

            var newUser = mapper.Map<AppUser>(model);
            newUser.UserName = model.Email;

            var result = await userManager.CreateAsync(newUser, model.PasswordConfirm!);

            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                    response.AddErrorMessage(err.Description);

                return response;
            }

            var userRole = await roleManager.Roles.FirstOrDefaultAsync(x => x.Name == "User");

            if (userRole != null)
            {
                await userManager.AddToRoleAsync(newUser, userRole.Name!);
                response.AddSuccessMessage("Kayıt İşlemi başarılı!");
            }
            else
                response.AddErrorMessage("Bir sorun meydana geldi.");

            return response;
        }
        
        public async Task<List<FavouriteStore>> GetAllFavouriteStoresAsync()
        {
            Guid UserGuid = httpContextAccessor.HttpContext.User.GetLoggedInUserId();
            return await unitOfWork.GetRepository<FavouriteStore>().GetAllAsync(
                predicate: x => x.UserId == UserGuid,
                include: source => source
                    .Include(x => x.User)
                    .Include(x => x.Store)
                    .ThenInclude(x => x.Address)
                    .ThenInclude(x => x.Country)
                    .Include(x => x.Store)
                    .ThenInclude(x => x.Address)
                    .ThenInclude(x => x.City)
                    .Include(x => x.Store)
                    .ThenInclude(x => x.Address)
                    .ThenInclude(x => x.District)
                    .Include(x => x.Store)
                    .ThenInclude(x => x.Images)
                    .ThenInclude(x => x.Image)
                );
        }

        public async Task<ServiceResponse<object>> ToggleLikeStoreAsync(Guid StoreId)
        {
            ServiceResponse<object> response = new ServiceResponse<object>();
            
            Guid UserGuid = httpContextAccessor.HttpContext.User.GetLoggedInUserId();
            
            bool likedBefore = await unitOfWork.GetRepository<FavouriteStore>().AnyAsync(
                predicate: x => x.UserId == UserGuid && x.StoreId == StoreId
                );
            if (!likedBefore)
            {
                FavouriteStore favStore = new FavouriteStore()
                {
                    UserId = UserGuid,
                    StoreId = StoreId,
                    CreatedBy = httpContextAccessor.HttpContext.User.GetLoggedInUserEmail()
                };

                await unitOfWork.GetRepository<FavouriteStore>().AddAsync( favStore );
            }
            else
            {
                FavouriteStore favouriteStore = await unitOfWork.GetRepository<FavouriteStore>().GetAsync(
                predicate: x => x.UserId == UserGuid && x.StoreId == StoreId
                );
                await unitOfWork.GetRepository<FavouriteStore>().DeleteAsync(favouriteStore);
            }

            await unitOfWork.SaveAsync();
            response.AddSuccessMessage("İşlem başarılı!");
            return response;
        }


        public async Task<ServiceResponse<object>> CreateComment(StoreCommentCreateViewModel model)
        {
            ServiceResponse<object> response = new ServiceResponse<object>();

            StoreComment comment = new StoreComment
            {
                StoreId = model.StoreId,
                UserId = httpContextAccessor.HttpContext.User.GetLoggedInUserId(),
                Score = model.Score,
                MessageContent = model.MessageContent,
                CreatedBy = httpContextAccessor.HttpContext.User.GetLoggedInUserEmail(),
            };

            await unitOfWork.GetRepository<StoreComment>().AddAsync(comment);
            await unitOfWork.SaveAsync();

            response.AddSuccessMessage("İşlem başarılı!");
            return response;
        }
        public async Task<List<StoreComment>> GetAllUserComments()
        {
            Guid UserGuid = httpContextAccessor.HttpContext.User.GetLoggedInUserId();

            return await unitOfWork.GetRepository<StoreComment>().GetAllAsync(
                predicate: x => x.UserId == UserGuid
                );
        }



        public async Task<UserProfileViewModel> GetUserDetailsAsync()
        {
            AppUser user = await userManager.GetUserAsync(httpContextAccessor.HttpContext.User);
            return mapper.Map<UserProfileViewModel>(user);
        }
        public async Task<ServiceResponse<object>> UpdateProfileDetailsAsync(UserProfileViewModel model)
        {
            ServiceResponse<object> response = new ServiceResponse<object>();

            try
            {
                AppUser user = await userManager.GetUserAsync(httpContextAccessor.HttpContext.User);

                user.FirstName = model.FirstName;
                user.LastName = model.LastName;

                var result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    await signInManager.SignOutAsync();
                    await signInManager.SignInAsync(user, true);
                    await unitOfWork.SaveAsync();
                }
                else
                {
                    response.AddErrorMessage("Güncelleme esnasında bir hata meydana geldi.");
                    return response;
                }
            }
            catch (Exception)
            {
                response.AddErrorMessage("Güncelleme esnasında bir hata meydana geldi.");
                return response;
            }

            response.AddSuccessMessage("Kullanıcı bilgileri başarıyla güncellendi!");
            return response;
        }

        public async Task<ServiceResponse<object>> UpdatePasswordAsync(ResetPasswordViewModel model)
        {
            ServiceResponse<object> response = new ServiceResponse<object>();

            try
            {
                AppUser user = await userManager.GetUserAsync(httpContextAccessor.HttpContext.User);
                if (user == null)
                {
                    response.AddErrorMessage($"Kullanıcı bilgilerine erişilemedi.");
                    return response;
                }

                var checkOldPassword = await userManager.CheckPasswordAsync(user, model.OldPassword);
                if (!checkOldPassword)
                {
                    response.AddErrorMessage("Şifreler uyuşmamaktadır!");
                    return response;
                }

                var result = await userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                if (!result.Succeeded)
                {
                    response.AddErrorMessage("Şifre değiştirme başarısız!");
                    return response;
                }

                await userManager.UpdateSecurityStampAsync(user);
                await signInManager.SignOutAsync();
                await signInManager.PasswordSignInAsync(user, model.NewPassword, true, false);
            }

            catch (Exception)
            {
                response.AddErrorMessage("Şifre değiştirme başarısız!");
                return response;
            }

            response.AddSuccessMessage("Şifreniz başarıyla değiştirildi!");
            return response;
        }
    }
}
