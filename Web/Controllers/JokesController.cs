using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    [Route("api/jokes")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            FunnyContext context = new FunnyContext();
            return Ok(context.Jokes.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            FunnyContext context = new FunnyContext();
            var vicc = (from x in context.Jokes
                       where id == x.JokeSk
                       select x).FirstOrDefault();
            return Ok(vicc);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FunnyContext context = new FunnyContext();
            var torlendo = (from x in context.Jokes
                        where id == x.JokeSk
                        select x).FirstOrDefault();
            context.Jokes.Remove(torlendo);
            context.SaveChanges();
        }

        [HttpPost]
        public void Post(string vicc)
        {
            FunnyContext context = new FunnyContext();
            Joke ujVicc = new Joke();
            ujVicc.JokeText = vicc;
            context.Jokes.Add(ujVicc);
            context.SaveChanges();
        }
    }
}
