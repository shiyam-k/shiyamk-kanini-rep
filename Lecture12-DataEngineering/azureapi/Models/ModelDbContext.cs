using Microsoft.EntityFrameworkCore;

namespace azureapi.Models
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options) { }
        public DbSet<Users> Users { get; set; }
        public DbSet<TestBoovie> Boos { get; set; }

    }
}
