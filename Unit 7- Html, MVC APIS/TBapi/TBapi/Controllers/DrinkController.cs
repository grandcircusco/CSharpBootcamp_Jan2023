using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TBapi.Models;

namespace TBapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : ControllerBase
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        [HttpGet]
        public List<Drink> GetAll()
        {
            return dbContext.Drinks.ToList();
        }

        [HttpGet("Slushie")]
        public List<Drink> GetBySlushie(bool slushie)
        {
            return dbContext.Drinks.Where(d => d.Slushie == slushie).ToList();
        }

        [HttpDelete("{id}")]
        public Drink DeleteById(int id)
        {
            Drink d = dbContext.Drinks.FirstOrDefault(d => d.Id == id);
            dbContext.Drinks.Remove(d);
            dbContext.SaveChanges();

            return d;
        }
    }
}
