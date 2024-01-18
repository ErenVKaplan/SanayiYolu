using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Project.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {

        [Route("admin")]
        [Route("admin/home")]
        [Route("admin/home/index")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
