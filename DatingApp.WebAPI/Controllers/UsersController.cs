using DatingApp.WebAPI.Data;
using DatingApp.WebAPI.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.WebAPI.Controllers
{
    public class UsersController(DataContext context) : BaseApiController
    {

        // GET: api/Users
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await context.Users.ToListAsync();
            return Ok(users);
        }

         // GET api/Users/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user =await  context.Users.FindAsync(id);
            if(user is null) return NotFound();
            return user;
        }
    }
}
