using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Social_App.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Social_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        MyContext _context;
        public LikeController(MyContext context)
        {
            _context = context;
        }

        // GET: api/<LikesController>
        [HttpGet, Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LikesController>/5
        [HttpGet("{id}"), Authorize]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LikesController>
        [HttpPost, Authorize]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LikesController>/5
        [HttpPut("{id}"), Authorize]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LikesController>/5
        [HttpDelete("{id}"), Authorize]
        public void Delete(int id)
        {
        }
    }
}
