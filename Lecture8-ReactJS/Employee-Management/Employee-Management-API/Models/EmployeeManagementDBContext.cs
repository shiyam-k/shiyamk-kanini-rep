using Microsoft.EntityFrameworkCore;

namespace Employee_Management_API.Models
{
    public class EmployeeManagementDBContext : DbContext
    {
        public EmployeeManagementDBContext(DbContextOptions<EmployeeManagementDBContext> options) : base(options) { }

        public DbSet<EmployeeData> EmployeeData { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<Domains> Domains { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<LoginLogs> LoginLogs { get; set; }
        //
        public DbSet<ProjTL> ProjectTL { get; set; }
        public DbSet<ProjEmployees> ProjectEmployees { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<TopicsDomains> TopicsDomains { get; set; }

    }
}
