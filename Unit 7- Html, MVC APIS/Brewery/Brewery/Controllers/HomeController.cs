using Brewery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Brewery.Controllers
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

        public IActionResult Tavern()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Tavern(string city, string cityState)
        {
            return View(TavernDAL.GetTaverns(city,cityState));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}