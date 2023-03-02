using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VotesEx.Models;

namespace VotesEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        VoteDbContext dbContext = new VoteDbContext();

        [HttpGet("getVotes")]
        public List<Vote> getVotes()
        {
            return dbContext.Votes.ToList();
        }

        [HttpPut("addVote")]
        public Vote addVote(int Id)
        {
            Vote v = dbContext.Votes.FirstOrDefault(v => v.Id == Id);
            v.Votes++;
            dbContext.Votes.Update(v);
            dbContext.SaveChanges();

            return v;
        }
    }
}
