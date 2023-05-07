using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_OnetoMany.Models;

public partial class HospitalDbContext : DbContext
{
    public HospitalDbContext()
    {
    }

    public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.Did);

            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.Dname).HasColumnName("DName");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Pid);

            entity.HasIndex(e => e.DoctorsDid, "IX_Patients_DoctorsDId");

            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.DoctorsDid).HasColumnName("DoctorsDId");
            entity.Property(e => e.Pname).HasColumnName("PName");

            entity.HasOne(d => d.DoctorsD).WithMany(p => p.Patients).HasForeignKey(d => d.DoctorsDid);
        });
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
