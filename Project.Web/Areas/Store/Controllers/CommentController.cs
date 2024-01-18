using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Service.Services.Abstract;

namespace Project.Web.Areas.Store.Controllers
{
    [Area("Store")]
    [Authorize(Roles = "Store")]
    public class CommentController : Controller
    {
        private readonly IStoreService storeService;

        public CommentController(IStoreService storeService)
        {
            this.storeService = storeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var comments = await storeService.GetAllStoreCommentsAsync();
            return View(comments);
        }
    }
}
