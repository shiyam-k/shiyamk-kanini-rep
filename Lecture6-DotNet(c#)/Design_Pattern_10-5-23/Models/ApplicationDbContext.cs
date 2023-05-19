using Microsoft.EntityFrameworkCore;

namespace Design_Pattern_10_5_23.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) :base(option) { }

        public DbSet<Employee> Employees { get; set;}
        public DbSet<Roles> Roles { get; set;}
        public DbSet<Projects> Projects { get; set;}
        public DbSet<Employee_Project> Employees_Projects { get; set;}


    }
}
