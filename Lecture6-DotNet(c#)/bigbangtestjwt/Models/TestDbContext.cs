using Microsoft.EntityFrameworkCore;

namespace bigbangtestjwt.Models
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
