using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_26_04_2023.Modals
{
    internal class CourseContext : DbContext
    {
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>()
                .HasOne<Course>(s => s.course)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.course);
        }*/
        public DbSet<Course> Courses { get;set; }
        public DbSet<Students> Students { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=LAPTOP-OJCNGD2Q\\SQLEXPRESS;Initial Catalog=CollegeDB;Integrated Security=True;trustservercertificate=true");

        }
    }
}
