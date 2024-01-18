using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using Project.Data.Entities;
using Project.Data.ViewModels.Stores;
using Project.Data.ViewModels.Users;
using Project.Service.Extensions;
using Project.Service.Services;
using Project.Service.Services.Abstract;

namespace Project.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;
        private readonly IUserService userService;
        private readonly IStoreService storeService;
        private readonly IAddressService addressService;
        private readonly IToastNotification toastNotification;
        private readonly IValidator<StoreLoginViewModel> storeLoginValidator;
        private readonly IValidator<StoreRegisterViewModel> storeRegisterValidator;
        private readonly IValidator<UserLoginViewModel> userLoginValidator;
        private readonly IValidator<UserRegisterViewModel> userRegisterValidator;

        public AuthController(SignInManager<AppUser> signInManager, IUserService userService, IStoreService storeService, IAddressService addressService, IToastNotification toastNotification, IValidator<StoreLoginViewModel> storeLoginValidator, IValidator<StoreRegisterViewModel> storeRegisterValidator, IValidator<UserLoginViewModel> userLoginValidator, IValidator<UserRegisterViewModel> userRegisterValidator)
        {
            this.signInManager = signInManager;
            this.userService = userService;
            this.storeService = storeService;
            this.addressService = addressService;
            this.toastNotification = toastNotification;
            this.storeLoginValidator = storeLoginValidator;
            this.storeRegisterValidator = storeRegisterValidator;
            this.userLoginValidator = userLoginValidator;
            this.userRegisterValidator = userRegisterValidator;
        }

        [HttpGet]
        public async Task<IActionResult> UserLogin()
        {
            return await Task.FromResult(View());
        }
        [HttpPost]
        public async Task<IActionResult> UserLogin(UserLoginViewModel model)
        {
            ValidationResult result = await userLoginValidator.ValidateAsync(model);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                toastNotification.AddErrorToastMessage("Gerekli alanları doldurunuz!", new ToastrOptions { Title = "Hata!" });
                return View(model);
            }

            ServiceResponse<object> response = await userService.LoginUserAsync(model);

            if (response.HasError)
            {
                foreach (var item in response.ErrorMessages)
                    toastNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });
             
                return View(model);
            }
            //Başarılı mesajı
            toastNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return RedirectToAction("Index", "Home", new { Area = "" });
        }
        [HttpGet]
        public async Task<IActionResult> UserRegister()
        {
            return await Task.FromResult(View());
        }
        [HttpPost]
        public async Task<IActionResult> UserRegister(UserRegisterViewModel model)
        {
            ValidationResult result = await userRegisterValidator.ValidateAsync(model);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                toastNotification.AddErrorToastMessage("Gerekli alanları doldurunuz!", new ToastrOptions { Title = "Hata!" });
                return View(model);
            }

            ServiceResponse<object> response = await userService.CreateUserAsync(model);
            if (response.HasError)
            {
                foreach (var item in response.ErrorMessages)
                    toastNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });

                return View(model);
            }
            //Başarılı mesajı
            toastNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return RedirectToAction("Index", "Home", new { Area = "" });
        }


        [HttpGet]
        public async Task<IActionResult> StoreLogin()
        {
            return await Task.FromResult(View());
        }
        [HttpPost]
        public async Task<IActionResult> StoreLogin(StoreLoginViewModel model)
        {
            ValidationResult result = await storeLoginValidator.ValidateAsync(model);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                toastNotification.AddErrorToastMessage("Gerekli alanları doldurunuz!", new ToastrOptions { Title = "Hata!" });
                return View(model);
            }

            ServiceResponse<object> response = await storeService.LoginStoreAsync(model);

            if (response.HasError)
            {
                foreach (var item in response.ErrorMessages)
                    toastNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });

                return View(model);
            }
            //Başarılı mesajı
            toastNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return RedirectToAction("Index", "Home", new { Area = "Store" });
        }
        [HttpGet]
        public async Task<IActionResult> StoreRegister()
        {
            StoreRegisterViewModel model = new StoreRegisterViewModel
            {
                Countries = await addressService.GetAllCountriesAsync(),
                Cities = await addressService.GetAllCitiesAsync(),
                Districts = await addressService.GetAllDistrictsAsync(),
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> StoreRegister(StoreRegisterViewModel model)
        {
            ValidationResult result = await storeRegisterValidator.ValidateAsync(model);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                toastNotification.AddErrorToastMessage("Gerekli alanları doldurunuz!", new ToastrOptions { Title = "Hata!" });

                model.Countries = await addressService.GetAllCountriesAsync();
                model.Cities = await addressService.GetAllCitiesAsync();
                model.Districts = await addressService.GetAllDistrictsAsync();
                return View(model);
            }

            ServiceResponse<object> response = await storeService.CreateStoreAsync(model);

            if (response.HasError)
            {
                foreach (var item in response.ErrorMessages)
                    toastNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });

                model.Countries = await addressService.GetAllCountriesAsync();
                model.Cities = await addressService.GetAllCitiesAsync();
                model.Districts = await addressService.GetAllDistrictsAsync();
                return View(model);
            }
            //Başarılı mesajı
            toastNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return RedirectToAction("Index", "Home", new { Area = "" });
        }


        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }


        // ADDRESS FUNCTIONS
        public async Task<JsonResult> GetCountriesAsync()
        {
            var countries = await addressService.GetAllCountriesAsync();
            return Json(countries.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.CountryName }).ToList());
        }
        public async Task<JsonResult> GetCitiesByCountryIdAsync(Guid Id)
        {
            var cities = await addressService.GetAllCitiesByCountryIdAsync(Id);
            return Json(cities.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.CityName }).ToList());
        }
        public async Task<JsonResult> GetDistrictsByCityIdAsync(Guid Id)
        {
            var districts = await addressService.GetAllDistrictsByCityIdAsync(Id);
            return Json(districts.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.DistrictName }).ToList());
        }
    }
}
