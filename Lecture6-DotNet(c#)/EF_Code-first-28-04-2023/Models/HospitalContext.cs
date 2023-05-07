using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Code_first_28_04_2023.Models
{
    internal class HospitalContext :  DbContext
    {
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Patients> Patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-OJCNGD2Q\\SQLEXPRESS;database=HospitalDB;Integrated Security=True;trustservercertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patients>()
                .Property(x => x.PId)
                .UseIdentityColumn(101, 1);
        }


    }
}
