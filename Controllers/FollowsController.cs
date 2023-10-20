using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Social_App.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Social_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowsController : ControllerBase
    {
        MyContext _context;
        public FollowsController(MyContext context)
        {
            _context = context;
        }

        // GET: api/<FollowController>
        [HttpGet, Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FollowController>/5
        [HttpGet("{id}"), Authorize]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FollowController>
        [HttpPost, Authorize]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FollowController>/5
        [HttpPut("{id}"), Authorize]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FollowController>/5
        [HttpDelete("{id}"), Authorize]
        public void Delete(int id)
        {
        }
    }
}
