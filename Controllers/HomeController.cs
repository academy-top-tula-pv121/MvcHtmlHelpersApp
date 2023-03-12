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

        public IActionResult Empl()
        {
            Employe e = new() { Name = "Bob", Age = 32 };
            return View(e);
        }
        
        public IActionResult Item()
        {
            return View();
        }

        public IActionResult List()
        {
            List<Book> books = new()
            {
                new(){ Id = 23, Title = "Mu-mu" },
                new(){ Id = 45, Title = "Ruslan and Ludmila" },
                new(){ Id = 128, Title = "Idiot" }
            };
            return View(books);
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