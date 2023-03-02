using ASPAngularLecture.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPAngularLecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        ResturantDbContext dbContext = new ResturantDbContext();

        [HttpGet()]
        public List<Order> GetAll()
        {
            return dbContext.Orders.ToList();
        }

        [HttpPost()]
        public Order CreateOrder(string _description, decimal _cost, int _rating)
        {
            Order newOrder = new Order()
            {
                Description = _description,
                Cost = _cost,
                Rating = _rating
            };
            dbContext.Orders.Add(newOrder);
            dbContext.SaveChanges();

            return newOrder;
        }
    }
}
