using Microsoft.EntityFrameworkCore;

namespace JWT_API25523.Models
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
