using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Intern_Explorer.Auth;



namespace Intern_Explorer.Auth
{
    public class InternDBContext : DbContext
    {
        public InternDBContext(DbContextOptions<InternDBContext> options) : base(options)
        {
        }

        public DbSet<InternData> InternData { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<LoginCredentials> LoginCredentials { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<EmployeeData> EmployeeData { get; set; }        
        public DbSet<LoginLog> LoginLogs { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
