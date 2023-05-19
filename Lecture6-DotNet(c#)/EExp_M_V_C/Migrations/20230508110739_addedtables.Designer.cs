﻿// <auto-generated />
using EExp_M_V_C.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EExp_M_V_C.Migrations
{
    [DbContext(typeof(EmployeeExplorerDBContext))]
    [Migration("20230508110739_addedtables")]
    partial class addedtables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EExp_M_V_C.Models.EmployeeCredentials", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("EmployeeCredentials");
                });

            modelBuilder.Entity("EExp_M_V_C.Models.Login", b =>
                {
                    b.Property<string>("SessionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeCredentialsEmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginEmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SessionId");

                    b.HasIndex("EmployeeCredentialsEmployeeId");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("EExp_M_V_C.Models.Login", b =>
                {
                    b.HasOne("EExp_M_V_C.Models.EmployeeCredentials", "EmployeeCredentials")
                        .WithMany()
                        .HasForeignKey("EmployeeCredentialsEmployeeId");

                    b.Navigation("EmployeeCredentials");
                });
#pragma warning restore 612, 618
        }
    }
}