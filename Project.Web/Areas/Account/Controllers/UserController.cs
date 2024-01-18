using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Project.Data.Entities;
using Project.Data.ViewModels.Users;
using Project.Service.Services;
using Project.Service.Services.Abstract;
using Project.Service.Services.Concrete;

namespace Project.Web.Controllers
{
    [Area("Account")]
    public class UserController : Controller
    {

        private readonly UserManager<AppUser> _UserManager;
        private readonly IUserService userService;
        private readonly IToastNotification _toastNotification;
        public UserController(UserManager<AppUser> userManager, IUserService userService, IToastNotification toastNotification)
        {

            _UserManager = userManager;
            this.userService = userService;
            _toastNotification = toastNotification;
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel request)
        {
            ServiceResponse<object> response = await userService.CreateUserAsync(request);

            if(response.HasError) 
            {
                foreach (var item in response.ErrorMessages)
                {
                    _toastNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });
                    return View();
                }
            }
            //Başarılı mesajı
            _toastNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return View();
     
        }

        public IActionResult SignIn() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginViewModel request, string? ReturnUrl = null)
        {
            ReturnUrl = ReturnUrl ?? Url.Action("Index", "Home");//Eğer returnurl null değilse kendi değeri atanır.Nullsa İndex Home gider.
            if (!ModelState.IsValid) 
            {
                ModelState.AddModelError(string.Empty, "Lütfen Her Yeri Doldurunuz");
                return View();
            }
            ServiceResponse<object> response = await userService.LoginUserAsync(request);

            if (response.HasError)
            {
                foreach (var item in response.ErrorMessages)
                {
                    _toastNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });
                    return View();
                }
            }
            //Başarılı mesajı
            _toastNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return RedirectToAction("Index","Home", new {Area=""});
           
        }
    }
}
