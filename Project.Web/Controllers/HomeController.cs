using Microsoft.AspNetCore.Mvc;
using Project.Service.Services.Abstract;

namespace Project.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreService storeService;
        private readonly IAddressService addressService;

        public HomeController(IStoreService storeService, IAddressService addressService)
        {
            this.storeService = storeService;
            this.addressService = addressService;
        }

        public async Task<IActionResult> Index()
        {
            var stores = await storeService.GetAllStoresAsync();
            ViewBag.Cities = await addressService.GetAllCitiesAsync();
            return View(stores.Take(5).ToList());
        }

        public async Task<IActionResult> Store(Guid Id)
        {
            var store = await storeService.GetStoreDetailsByStoreIdAsync(Id);
            return View(store);
        }
        public async Task<IActionResult> Stores(Guid? Location)
        {
            var stores = await storeService.GetAllStoresAsync();

            if (Location != null)
                stores = stores.Where(x => x.Address.CityId == Location).ToList();

            return View(stores);
        }

    }
}