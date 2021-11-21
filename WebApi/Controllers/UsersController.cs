using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly EfDatabaseFirstContext _context;

        public UsersController(EfDatabaseFirstContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        //{
        //    return await _context.Users.ToListAsync();
        //}

        public async Task<ActionResult<IEnumerable<UserShow>>> GetUsers()
        
            
        {

            var Users = new List<UserShow>();

            foreach (var user in await _context.Users.ToListAsync())
                Users.Add(new UserShow
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email
                });

            return Users;

            // return await _context.Users.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)

        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }



        // POST: api/Users
        [HttpPost]
        //public async Task<ActionResult<User>> PostUser(User user)
        public async Task<ActionResult<User>> PostUser(UserCreateModel model)
        {
            //    _context.Users.Add(user);
            //    await _context.SaveChangesAsync();
            //    return CreatedAtAction("GetUser", new { id = user.Id }, user);

            var user = await _context.Users.Where(x => x.Email == model.Email).FirstOrDefaultAsync();

            if (user == null)
            {
                var _user = new User
                {
                    //Id = Guid.NewGuid(),
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                };

                _context.Users.Add(_user);
                await _context.SaveChangesAsync();

                var userId = await _context.Users.Where(x => x.Id == _user.Id).FirstOrDefaultAsync();

                return CreatedAtAction("GetUser", new { id = userId.Id }, User);
            }
            return new ConflictResult();
        }




        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
