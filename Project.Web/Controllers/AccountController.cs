using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Project.Data.ViewModels.StoreComments;
using Project.Data.ViewModels.Users;
using Project.Service.Services;
using Project.Service.Services.Abstract;

namespace Project.Web.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly IToastNotification _toastrNotification;
        private readonly IUserService userService;

        public AccountController(IToastNotification toastrNotification, IUserService userService)
        {
            _toastrNotification = toastrNotification;
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await userService.GetUserDetailsAsync();
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(UserProfileViewModel model)
        {
            if (!User.Identity.IsAuthenticated)
            {
                _toastrNotification.AddErrorToastMessage("Bu işlemi yapmak için giriş yapmanız gerekmektedir!", new ToastrOptions { Title = "Hata!" });
                return Redirect(Request.Headers["Referer"].ToString());
            }

            ServiceResponse<object> response = await userService.UpdateProfileDetailsAsync(model);
            if (response.HasError)
            {
                foreach (var item in response.ErrorMessages)
                    _toastrNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });

                return Redirect(Request.Headers["Referer"].ToString());
            }
            //Başarılı mesajı
            _toastrNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return Redirect(Request.Headers["Referer"].ToString());
        }


        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!User.Identity.IsAuthenticated)
            {
                _toastrNotification.AddErrorToastMessage("Bu işlemi yapmak için giriş yapmanız gerekmektedir!", new ToastrOptions { Title = "Hata!" });
                return Redirect(Request.Headers["Referer"].ToString());
            }

            ServiceResponse<object> response = await userService.UpdatePasswordAsync(model);
            if (response.HasError)
            {
                foreach (var item in response.ErrorMessages)
                    _toastrNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });

                return Redirect(Request.Headers["Referer"].ToString());
            }
            //Başarılı mesajı
            _toastrNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return Redirect(Request.Headers["Referer"].ToString());
        }


        [HttpGet]
        public async Task<IActionResult> Favourites()
        {
            if (!User.Identity.IsAuthenticated)
            {
                _toastrNotification.AddErrorToastMessage("Bu işlemi yapmak için giriş yapmanız gerekmektedir!", new ToastrOptions { Title = "Hata!" });
                return Redirect(Request.Headers["Referer"].ToString());
            }

            var favourites = await userService.GetAllFavouriteStoresAsync();
            return View(favourites);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(StoreCommentCreateViewModel model)
        {
            if (!User.Identity.IsAuthenticated)
            {
                _toastrNotification.AddErrorToastMessage("Bu işlemi yapmak için giriş yapmanız gerekmektedir!", new ToastrOptions { Title = "Hata!" });
                return Redirect(Request.Headers["Referer"].ToString());
            }

            ServiceResponse<object> response = await userService.CreateComment(model);
            if (response.HasError)
            {
                foreach (var item in response.ErrorMessages)
                    _toastrNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });

                return Redirect(Request.Headers["Referer"].ToString());
            }
            //Başarılı mesajı
            _toastrNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public async Task<IActionResult> ToggleFavourites(Guid StoreId)
        {
            if (!User.Identity.IsAuthenticated)
            {
                _toastrNotification.AddErrorToastMessage("Bu işlemi yapmak için giriş yapmanız gerekmektedir!", new ToastrOptions { Title = "Hata!" });
                return Redirect(Request.Headers["Referer"].ToString());
            }

            ServiceResponse<object> response = await userService.ToggleLikeStoreAsync(StoreId);
            if (response.HasError)
            {
                foreach (var item in response.ErrorMessages)
                    _toastrNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });

                return Redirect(Request.Headers["Referer"].ToString());
            }
            //Başarılı mesajı
            _toastrNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
