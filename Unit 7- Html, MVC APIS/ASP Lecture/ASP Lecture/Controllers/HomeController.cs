using ASP_Lecture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_Lecture.Controllers
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
        public IActionResult Form()
        {
            return View();
        }


        //public IActionResult Result(string name, int age)
        //{
        //    string result = $"We have collected {name}. They are {age} years old";
        //    return View(result);
        //}

        public IActionResult Result(Cat c)
        {
            return View(c);
        }

        public IActionResult About()
        {
            string name = "Justin";
            ViewData["Name"] = name;
            //Name is stored in the dictionary.
            //ViewData can be used on the View
            return View();
        }

        public IActionResult Privacy()
        {
            int Year = 2023;
            return View(Year);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}