using ApiLecture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApiLecture.Controllers
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

        public IActionResult HallOfFame()
        {
            return View(HallOfFameDAL.GetHallOfFame());
        }

        public IActionResult Weather()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Weather(string city)
        {
            return View(WeatherDAL.GetWeather(city));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}