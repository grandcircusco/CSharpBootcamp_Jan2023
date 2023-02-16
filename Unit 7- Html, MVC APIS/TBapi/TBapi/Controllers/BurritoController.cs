using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TBapi.Models;

namespace TBapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BurritoController : ControllerBase
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();
        //api/burrito
        [HttpGet]
        public List<Burrito> GetAll()
        {
            return dbContext.Burritos.ToList();
        }
        //api/burrito/beans?beans=true
        //api/burrito/beans?beans=false
        [HttpGet("beans")]
        public List<Burrito> GetAllByBeans(bool beans)
        {
            return dbContext.Burritos.Where(b => b.Bean == beans).ToList();
        }


        [HttpPost]
        public Burrito AddBurrito(string name, float cost, bool bean)
        {
            Burrito newBurrito = new Burrito()
            {
                Name = name,
                Cost = cost,
                Bean = bean
            };

            dbContext.Burritos.Add(newBurrito);
            dbContext.SaveChanges();

            return newBurrito;           
        }
    }
}
