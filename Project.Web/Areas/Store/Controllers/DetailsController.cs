using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Project.Data.ViewModels.Stores;
using Project.Service.Extensions;
using Project.Service.Services;
using Project.Service.Services.Abstract;

namespace Project.Web.Areas.Store.Controllers
{
    [Area("Store")]
    [Authorize(Roles = "Store")]
    public class DetailsController : Controller
    {
        private readonly IStoreService storeService;
        private readonly IMapper mapper;
        private readonly IValidator<StoreDetailsViewModel> storeValidator;
        private readonly IToastNotification toastNotification;

        public DetailsController(IStoreService storeService, IMapper mapper, IValidator<StoreDetailsViewModel> storeValidator, IToastNotification toastNotification)
        {
            this.storeService = storeService;
            this.mapper = mapper;
            this.storeValidator = storeValidator;
            this.toastNotification = toastNotification;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var store = await storeService.GetStoreDetailsAsync();
            return View(mapper.Map<StoreDetailsViewModel>(store));
        }

        [HttpPost]
        public async Task<IActionResult> Index(StoreDetailsViewModel model)
        {
            ValidationResult result = await storeValidator.ValidateAsync(model);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                toastNotification.AddErrorToastMessage("Gerekli alanları doldurunuz!", new ToastrOptions { Title = "Hata!" });
                return View(model);
                //return RedirectToAction("Index", "Details", new { Area = "Store" });
            }

            ServiceResponse<object> response = await storeService.UpdateStoreDetailsAsync(model);

            if (response.HasError)
            {
                foreach (var item in response.ErrorMessages)
                    toastNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });

                return View(model);
            }
            //Başarılı mesajı
            toastNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return RedirectToAction("Index", "Details", new { Area = "Store" });
        }
    }
}
