using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Social_App.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Social_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        MyContext _context;
        public PostsController(MyContext context)
        {
            _context = context;
        }

        // GET: api/<PostController>
        [HttpGet, Authorize]
        public IEnumerable<Post> Get()
        {
            return _context.Posts.ToList();
        }

        // GET api/<PostController>/5
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            Post? post = _context.Posts.FirstOrDefault(record => record.Id == id);
            if (post != null) return Ok(post);
            return BadRequest();
        }

        // POST api/<PostController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Post post)
        {
            if (ModelState.IsValid)
            {
                _context.Posts.Add(post);
                _context.SaveChanges();
                return Ok(post);
            }
            return BadRequest();
        }

        // PUT api/<PostController>/5
        [HttpPut("{id}"), Authorize]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PostController>/5
        [HttpDelete("{id}"), Authorize]
        public void Delete(int id)
        {
        }
    }
}
