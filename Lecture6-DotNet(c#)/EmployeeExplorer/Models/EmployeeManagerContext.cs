using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;


namespace EmployeeExplorer.Models
{
    public class EmployeeManagerContext : DbContext
    {
        /*private readonly EmployeeManagerContext emContext;
        */

        public virtual DbSet<Register> Register { get; set; }

        public EmployeeManagerContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Register>()
                .HasKey(e => e.UserId);
        }

    }
}