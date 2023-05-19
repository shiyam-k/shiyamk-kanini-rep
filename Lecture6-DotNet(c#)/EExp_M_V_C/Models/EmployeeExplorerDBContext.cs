using Microsoft.EntityFrameworkCore;

namespace EExp_M_V_C.Models
{
    public class EmployeeExplorerDBContext : DbContext
    {
        public EmployeeExplorerDBContext(DbContextOptions<EmployeeExplorerDBContext> options) : base(options) { }

        public DbSet<EmployeeCredentials> EmployeeCredentials { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
