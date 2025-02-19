using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Day02.Models;

namespace MVC_Day_1.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }

        public IActionResult info(int id)
        {
            if (id == 1)
            {
                return Content($"Hello from Id {id}");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult razer()
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
