using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TorahLibrary.DAL;
using TorahLibrary.Models;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Create()
        {
            return View(new Libraries());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(Libraries libraries)
        {
            Data.Get.Libraries.Add(libraries);
            Data.Get.SaveChanges();
            return RedirectToAction("Libraries");
        }

        public IActionResult CreateBook()
        {
            return View( new Books());
        }

        public IActionResult AddShelf(int LiberyId)
        {
            Shelves shelves = new Shelves();
            shelves.LiberyId = LiberyId;
            return View(shelves);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddShelf(Shelves shelves)
        {
            Data.Get.Shelv.Add(shelves);
            Data.Get.SaveChanges();
            return RedirectToAction("Libraries");
        }


        public IActionResult Libraries()
        {
            List<Libraries> MyLibrary = Data.Get.Libraries.ToList();
            return View(MyLibrary);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
        //[HttpPost, ValidateAntiForgeryToken]
        //public IActionResult CreateLiber(Libraries libraries)
        //{
        //    if (libraries == null)
        //    {
        //        return RedirectToAction("Libraries");
        //    }
        //    Data.Get.Libraries.Add(libraries);
        //    Data.Get.SaveChanges();
        //    return RedirectToAction("Libraries");
        //}
