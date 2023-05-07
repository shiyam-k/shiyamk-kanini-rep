using Microsoft.EntityFrameworkCore;

namespace IRepository_Hospital_5_5_23.Models
{
    public partial class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        {
        }

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
}
