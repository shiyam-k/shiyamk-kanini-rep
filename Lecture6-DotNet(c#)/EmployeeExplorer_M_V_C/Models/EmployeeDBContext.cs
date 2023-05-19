using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using System;


namespace EmployeeExplorer_M_V_C.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options) { }

        public DbSet<EmployeeCredentials> EmployeeCredentials { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Clients> Clients { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Engineer_Project> EngineerProjects { get; set; }
        public DbSet<Manager_Project> ManagerProjects { get; set; }
        public DbSet<Employee_Role> EmployeeRoles { get; set; }

        /*public override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCredentials>().Has
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
