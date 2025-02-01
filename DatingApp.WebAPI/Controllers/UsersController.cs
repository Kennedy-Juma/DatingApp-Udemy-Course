using DatingApp.WebAPI.Data;
using DatingApp.WebAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(DataContext context) : ControllerBase
    {

        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = context.Users.ToList(); 
            return Ok(users);
        }

         // GET api/Users/5
        [HttpGet("{id:int}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            var user = context.Users.Find(id);
            if(user is null) return NotFound();
            return user;
        }

        /*// GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
