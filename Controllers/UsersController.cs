using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Social_App.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Social_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        MyContext _context;
        public UsersController(MyContext context)
        {
            _context = context;
        }

        // GET: api/<UserController>
        [HttpGet, Authorize]
        public ActionResult Get()
        {
            // Not letting anyone get all users info
            return BadRequest();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}"), Authorize]
        public ActionResult Get(string id)
        {
            User? user = _context.Users.FirstOrDefault(record => record.Clerk_Id == id);
            if (user != null) return Ok(user);
            return BadRequest();
        }

        // POST api/<UserController>
        [HttpPost, Authorize]
        public ActionResult Post([FromBody] User newUser)
        {
            if (ModelState.IsValid)
            {
                if (!_context.Users.Any(record => record.Email == newUser.Email))
                {
                    if (_context.Users.Any(record => record.Username == newUser.Username))
                        return BadRequest("Username is in-use");
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    // Updating our newUser's password to a hashed version         
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    _context.Add(newUser);
                    _context.SaveChanges();
                    return Ok(newUser);
                }
                return BadRequest("Email is in-use");
            }
            return NotFound("Invalid Information");
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}"), Authorize]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}"), Authorize]
        public void Delete(int id)
        {
        }
    }
}