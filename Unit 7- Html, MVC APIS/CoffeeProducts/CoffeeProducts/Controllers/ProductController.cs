using CoffeeProducts.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeProducts.Controllers
{
    public class ProductController : Controller
    {
        private ProductDbContext dbConext = new ProductDbContext();
        public IActionResult Index()
        {
            return View(ProductDAL.GetAll());
        }

        public IActionResult Detail(int id)
        {
            return View(ProductDAL.GetById(id));
        }
        public IActionResult Categories()
        {
            return View(ProductDAL.GetAllCategories());
        }

        public IActionResult ProductsByCategory(string category)
        {
            return View(ProductDAL.GetAllByCategory(category));
        }
    }
}
