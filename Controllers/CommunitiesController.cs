﻿using Microsoft.AspNetCore.Mvc;
using Social_App.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Social_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunitiesController : ControllerBase
    {
        MyContext _context;
        public CommunitiesController(MyContext context)
        {
            _context = context;
        }

        // GET: api/<CommunityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CommunityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CommunityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CommunityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CommunityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
