using Microsoft.EntityFrameworkCore;

namespace InternzConnectAPI.Models
{
    public class InternzDbContext : DbContext
    {
        public InternzDbContext(DbContextOptions options) : base(options) { }
        public DbSet<EmployeeData> EmployeeData { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<LoginLogs> LoginLogs { get; set; }
    }
}
