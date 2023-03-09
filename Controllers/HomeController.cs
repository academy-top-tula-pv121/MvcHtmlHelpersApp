using Microsoft.AspNetCore.Mvc;
using MvcHtmlHelpersApp.Models;
using System.Diagnostics;

namespace MvcHtmlHelpersApp.Controllers
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

        [HttpGet]
        public IActionResult UserInfo() => View();

        [HttpPost]
        public IActionResult UserInfo(string name, int age) => Content($"Name: {name}, Age: {age}");
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}