using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TBapi.Models;

namespace TBapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacoController : ControllerBase
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        //api/taco
        [HttpGet]
        public List<Taco> GetAll()
        {
            return dbContext.Tacos.ToList();
        }

        //api/taco/id
        //api/taco/3
        [HttpGet("{id}")]
        public Taco GetById(int id)
        {
            return dbContext.Tacos.FirstOrDefault(t => t.Id == id);
        }

        [HttpPost]
        public Taco AddTaco(string name, float cost, bool softShell, bool Dorito)
        {
            Taco newTaco = new Taco()
            {
                Name = name,
                Cost = cost,
                SoftShell = softShell,
                Dorito = Dorito
            };

            dbContext.Tacos.Add(newTaco);
            dbContext.SaveChanges();

            return newTaco;
        }

        //api/taco/id?name=newName
        //api/taco/2?name=taco supreme
        [HttpPut("{id}")]
        public Taco ChangeTacoName(int id, string name)
        {
            Taco t = dbContext.Tacos.FirstOrDefault(t => t.Id == id);
            t.Name = name;

            dbContext.Tacos.Update(t);
            dbContext.SaveChanges();

            return t;
        }
    }
}
