using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using JWT_API_9_5_23.Auth;

namespace JWT_API_9_5_23.Models
{
    public class TempDbContext : IdentityDbContext<IdentityUser>
    {
        public TempDbContext(DbContextOptions<TempDbContext> options) : base(options)
        {
        }

        public DbSet<ProjectResources> ProjectResources { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
