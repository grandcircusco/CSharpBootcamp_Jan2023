using Deck_of_Cards.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Deck_of_Cards.Controllers
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

        public IActionResult Cards()
        {
            DeckModel result = DeckDAL.GetDeckModel(5);

            if(result.Remaining == 0)
            {
                DeckDAL.ShuffleDeck();
            }

            return View(result);
        }

        [HttpPost]
        public IActionResult Cards(string card0, string card1, string card2, string card3,string card4)
        {
            int newCards = 5;
            if(card0 != null && card0 != "")
            {
                newCards--;
            }
            if (card1 != null && card1 != "")
            {
                newCards--;
            }
            if (card2 != null && card2 != "")
            {
                newCards--;
            }
            if (card3 != null && card3 != "")
            {
                newCards--;
            }
            if (card4 != null && card4 != "")
            {
                newCards--;
            }


            DeckModel result = DeckDAL.GetDeckModel(newCards);

            if (card0 != null && card0 != "")
            {
                result.Cards.Add(new Card() { Image = new Uri(card0) });
            }
            if (card1 != null && card1 != "")
            {
                result.Cards.Add(new Card() { Image = new Uri(card1) });
            }
            if (card2 != null && card2 != "")
            {
                result.Cards.Add(new Card() { Image = new Uri(card2) });
            }
            if (card3 != null && card3 != "")
            {
                result.Cards.Add(new Card() { Image = new Uri(card3) });
            }
            if (card4 != null && card4 != "")
            {
                result.Cards.Add(new Card() { Image = new Uri(card4) });
            }




            if (result.Remaining == 0)
            {
                DeckDAL.ShuffleDeck();
            }

            return View(result);
        }


        public IActionResult Shuffle()
        {
            DeckDAL.ShuffleDeck();
            return RedirectToAction("Cards");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}