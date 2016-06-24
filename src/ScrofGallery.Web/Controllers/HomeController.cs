using Microsoft.AspNetCore.Mvc;
using ScrofGallery.Domain.DataAccess;
using ScrofGallery.Web.DataAccess;
using System.Linq;

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
            var items = _itemRepository.GetAllItems();
            //_context.GalleryItems.ToList();
            return View();
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
