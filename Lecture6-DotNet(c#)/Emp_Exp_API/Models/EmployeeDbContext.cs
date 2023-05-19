using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Emp_Exp_API.Models;

public partial class EmployeeDbContext : DbContext
{

    public EmployeeDbContext()
    {
    }

    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeCredential> EmployeeCredentials { get; set; }

    public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }

    public virtual DbSet<EngineerProject> EngineerProjects { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<ManagerProject> ManagerProjects { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-OJCNGD2Q\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True; trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeCredential>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);

            entity.Property(e => e.Email).HasDefaultValueSql("(N'')");
            entity.Property(e => e.Password).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<EmployeeRole>(entity =>
        {
            entity.HasKey(e => e.Erid);

            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeRoles_EmployeeId");

            entity.HasIndex(e => e.RoleId, "IX_EmployeeRoles_RoleId");

            entity.Property(e => e.Erid).HasColumnName("ERId");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeRoles).HasForeignKey(d => d.EmployeeId);

            entity.HasOne(d => d.Role).WithMany(p => p.EmployeeRoles).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<EngineerProject>(entity =>
        {
            entity.HasIndex(e => e.EngineerEmployeeId, "IX_EngineerProjects_EngineerEmployeeId");

            entity.HasIndex(e => e.ManagerProjectId, "IX_EngineerProjects_ManagerProjectId");

            entity.HasIndex(e => e.ProjectsProjectId, "IX_EngineerProjects_ProjectsProjectId");

            entity.Property(e => e.EngineerProjectId).HasColumnName("Engineer_projectId");
            entity.Property(e => e.ManagerProjectId).HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.EngineerEmployee).WithMany(p => p.EngineerProjects).HasForeignKey(d => d.EngineerEmployeeId);

            entity.HasOne(d => d.ManagerProject).WithMany(p => p.EngineerProjects).HasForeignKey(d => d.ManagerProjectId);

            entity.HasOne(d => d.ProjectsProject).WithMany(p => p.EngineerProjects).HasForeignKey(d => d.ProjectsProjectId);
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.SessionId);

            entity.HasIndex(e => e.EmployeeCredentialsEmployeeId, "IX_Logins_EmployeeCredentialsEmployeeId");

            entity.HasOne(d => d.EmployeeCredentialsEmployee).WithMany(p => p.Logins).HasForeignKey(d => d.EmployeeCredentialsEmployeeId);
        });

        modelBuilder.Entity<ManagerProject>(entity =>
        {
            entity.HasIndex(e => e.ManagerEmployeeId, "IX_ManagerProjects_ManagerEmployeeId");

            entity.HasIndex(e => e.ProjectsProjectId, "IX_ManagerProjects_ProjectsProjectId");

            entity.HasOne(d => d.ManagerEmployee).WithMany(p => p.ManagerProjects).HasForeignKey(d => d.ManagerEmployeeId);

            entity.HasOne(d => d.ProjectsProject).WithMany(p => p.ManagerProjects).HasForeignKey(d => d.ProjectsProjectId);
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasIndex(e => e.ClientsClientId, "IX_Projects_ClientsClientId");

            entity.HasOne(d => d.ClientsClient).WithMany(p => p.Projects).HasForeignKey(d => d.ClientsClientId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
