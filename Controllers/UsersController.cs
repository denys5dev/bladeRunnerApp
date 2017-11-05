using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BladeRunnerApp.Controllers.Resources;
using BladeRunnerApp.Models;
using BladeRunnerApp.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BladeRunnerApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly BladeRunnerDbContext context;
        private readonly IMapper mapper;
        public UsersController(BladeRunnerDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/users")]
        public async Task<IEnumerable<UserResource>> GetUsers()
        {
            var users =  await context.Users.Include(u => u.UserRole).ToListAsync();

            return mapper.Map<List<User>, List<UserResource>>(users);
        }
    }
}