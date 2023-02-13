using ASP_EF_Lecture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_EF_Lecture.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //Allow access to the DB
        private BirdDbContext dbContext = new BirdDbContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //grabbing all posts
            List<Post> result = dbContext.Posts.ToList();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PostDetails(int id)
        {
            Post result = dbContext.Posts.FirstOrDefault(p => p.Id == id);
            return View(result);
        }

        public IActionResult AddPost(Post p)
        {
            //changing the nulls to a default
            p.Likes = 0;
            p.DatePosted = DateTime.Now;

            //Add it to the DB
            dbContext.Posts.Add(p);
            dbContext.SaveChanges();

            return RedirectToAction("Index");//send you back to the INDEX Page
        }

        public IActionResult AddLike(int id)
        {
            Post result = dbContext.Posts.FirstOrDefault(p => p.Id == id);
            result.Likes++;

            //update the db
            dbContext.Posts.Update(result);
            dbContext.SaveChanges();

            return RedirectToAction("PostDetails", new { id = id});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}