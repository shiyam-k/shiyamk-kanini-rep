using Microsoft.EntityFrameworkCore;
using System.Numerics;
using API_test__03_05_23.Models;
using API_test__03_05_23.Controllers;


namespace API_test__03_05_23.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options): base(options)
        {
        }

        public virtual DbSet<Library> Library { get; set; }


        
    }
}
