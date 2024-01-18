using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Project.Data.ViewModels.StoreImages;
using Project.Service.Services;
using Project.Service.Services.Abstract;

namespace Project.Web.Areas.Store.Controllers
{
    [Area("Store")]
    [Authorize(Roles = "Store")]
    public class ImageController : Controller
    {
        private readonly IStoreService storeService;
        private readonly IToastNotification toastNotification;

        public ImageController(IStoreService storeService, IToastNotification toastNotification)
        {
            this.storeService = storeService;
            this.toastNotification = toastNotification;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var images = await storeService.GetAllStoreImagesAsync();
            return View(images);
        }

        [HttpPost]
        public async Task<IActionResult> CreateImages(StoreImageCreateViewModel model)
        {
            if (!model.Images.Any())
            {
                toastNotification.AddErrorToastMessage("Lütfen en az bir resim seçiniz.", new ToastrOptions { Title = "Hata!" });
                return RedirectToAction("Index", "Image", new { Area = "Store" });
            }

            ServiceResponse<object> response = await storeService.CreateStoreImageAsync(model);

            if (response.HasError)
            {
                foreach (var item in response.ErrorMessages)
                    toastNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });

                return RedirectToAction("Index", "Image", new { Area = "Store" });
            }
            //Başarılı mesajı
            toastNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return RedirectToAction("Index", "Image", new { Area = "Store" });
        }
        [HttpPost]
        public async Task<IActionResult> DeleteImage(Guid Id)
        {
            ServiceResponse<object> response = await storeService.DeleteStoreImageAsync(Id);

            if (response.HasError)
            {
                foreach (var item in response.ErrorMessages)
                    toastNotification.AddErrorToastMessage(item, new ToastrOptions { Title = "Hata!" });
                
                return RedirectToAction("Index", "Image", new { Area = "Store" });
            }
            //Başarılı mesajı
            toastNotification.AddSuccessToastMessage(response.SuccessMessages.First(), new ToastrOptions { Title = "Başarılı!" });
            return RedirectToAction("Index", "Image", new { Area = "Store" });
        }
    }
}
