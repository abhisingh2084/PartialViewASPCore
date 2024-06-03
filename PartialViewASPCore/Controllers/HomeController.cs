using Microsoft.AspNetCore.Mvc;
using PartialViewASPCore.Models;
using System.Diagnostics;

namespace PartialViewASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Web 1", Description = "Website 1", Price = 60000, Image = "~/Images/image1.png"},
                new Product() { Id = 2, Name = "Web 2", Description = "Website 2", Price = 70000, Image = "~/Images/image2.png"},
                new Product() { Id = 3, Name = "Web 3", Description = "Website 3", Price = 80000, Image = "~/Images/image3.png"}
            };
            return View(products);
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
