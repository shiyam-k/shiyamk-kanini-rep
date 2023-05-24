using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternConnect_API.Models
{
    public class EmployeeDbContext : IdentityDbContext<Employee>
    {
        public EmployeeDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Login> Logins { get; set; }

        public DbSet<EmployeeDetails> EmployeeDetails { get; set;}
    }
}
