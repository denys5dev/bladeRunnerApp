using BladeRunnerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BladeRunnerApp.Persistence
{
    public class BladeRunnerDbContext : DbContext
    {
        public BladeRunnerDbContext(DbContextOptions<BladeRunnerDbContext> options)
            :base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}