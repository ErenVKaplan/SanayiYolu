using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Service.Services.Abstract;

namespace Project.Web.Areas.Store.Controllers
{

    [Area("Store")]
    [Authorize(Roles = "Store")]
    public class HomeController : Controller
    {
        private readonly IStoreService storeService;

        public HomeController(IStoreService storeService)
        {
            this.storeService = storeService;
        }

        [Route("Store")]
        [Route("Store/Home")]
        [Route("Store/Home/Index")]
        public async Task<IActionResult> Index()
        {
            var store = await storeService.GetStoreDetailsAsync();
            return View(store);
        }

        [HttpPost]
        public async Task<IActionResult> ToggleOnAir()
        {
            await storeService.ToggleOnAir();
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
