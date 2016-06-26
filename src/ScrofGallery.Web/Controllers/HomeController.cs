using Microsoft.AspNetCore.Mvc;
using ScrofGallery.Web.DataAccess;
using ScrofGallery.Web.Models;

namespace ScrofGallery.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGalleryItemRepository _itemRepository;

        public HomeController(IGalleryItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public IActionResult Index()
        {
            var model = new GalleryModel { Items = _itemRepository.GetAllItems() };
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
