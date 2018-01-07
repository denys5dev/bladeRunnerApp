using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BladeRunnerApp.Controllers.Resources;
using BladeRunnerApp.Models;
using BladeRunnerApp.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BladeRunnerApp.Controllers
{
    [Route("/api/users")]
    public class UsersController : Controller
    {
        private readonly BladeRunnerDbContext context;
        private readonly IMapper mapper;
        public UsersController(BladeRunnerDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<UserResource>> GetUsers()
        {
            var users =  await context.Users.Include(u => u.UserRole).ToListAsync();

            return mapper.Map<List<User>, List<UserResource>>(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody]UserResource userResource)
        {

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var email = context.Users.FirstOrDefault(u => u.Email.ToLower() == userResource.Contact.Email.ToLower());
           

            if(email != null) {
                ModelState.AddModelError("Email", "This email already exist!");
                return BadRequest(ModelState);
            }
                
            var user  = mapper.Map<UserResource, User>(userResource);

            user.UserRoleId = 2;
            user.CreatedAt = DateTime.Now;

            context.Users.Add(user);
            await context.SaveChangesAsync();

            var result = mapper.Map<User, UserResource>(user);

            return Ok(result);
        }
    }
}