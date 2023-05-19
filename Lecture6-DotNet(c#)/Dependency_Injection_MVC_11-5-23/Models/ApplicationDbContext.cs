using Microsoft.EntityFrameworkCore;

namespace Dependency_Injection_MVC_11_5_23.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option) { }


        public DbSet<Projects> Projects { get; set; }

    }
}
