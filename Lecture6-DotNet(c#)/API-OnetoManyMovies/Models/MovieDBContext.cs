using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace API_OnetoManyMovies.Models
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Movies> Movies { get; set; }

        public virtual DbSet<Director> Director { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>()
                .HasOne(a => a.Director)
                .WithMany(b => b.Movies)
                .HasForeignKey(c =>c.DirectorId);

        }
    }
}
