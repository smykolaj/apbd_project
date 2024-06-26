﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Context;

#nullable disable

namespace Project.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20240626165111_ChangedPrecisionForDiscountValue")]
    partial class ChangedPrecisionForDiscountValue
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.5.24306.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project.Models.AppUser", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Project.Models.Category", b =>
                {
                    b.Property<long>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdCategory"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdCategory");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Project.Models.Company", b =>
                {
                    b.Property<long>("IdCompany")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdCompany"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Krs")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("IdCompany");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Project.Models.Contract", b =>
                {
                    b.Property<long>("IdContract")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdContract"));

                    b.Property<int>("ContinuedSupportYears")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FullPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("IdCompany")
                        .HasColumnType("bigint");

                    b.Property<long?>("IdIndividual")
                        .HasColumnType("bigint");

                    b.Property<long>("IdSoftware")
                        .HasColumnType("bigint");

                    b.Property<long>("IdVersion")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdContract");

                    b.HasIndex("IdCompany");

                    b.HasIndex("IdIndividual");

                    b.HasIndex("IdSoftware");

                    b.HasIndex("IdVersion");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Project.Models.Discount", b =>
                {
                    b.Property<long>("IdDiscount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdDiscount"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Offer")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Value")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.HasKey("IdDiscount");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Project.Models.Individual", b =>
                {
                    b.Property<long>("IdIndividual")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdIndividual"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Pesel")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("IdIndividual");

                    b.ToTable("Individuals");
                });

            modelBuilder.Entity("Project.Models.Payment", b =>
                {
                    b.Property<int>("IdPayment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPayment"));

                    b.Property<decimal>("Amount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("IdContract")
                        .HasColumnType("bigint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IdPayment");

                    b.HasIndex("IdContract");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Project.Models.Software", b =>
                {
                    b.Property<long>("IdSoftware")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdSoftware"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("IdCategory")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdSoftware");

                    b.HasIndex("IdCategory");

                    b.ToTable("Softwares");
                });

            modelBuilder.Entity("Project.Models.Version", b =>
                {
                    b.Property<long>("IdVersion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdVersion"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("IdSoftware")
                        .HasColumnType("bigint");

                    b.Property<string>("VersionNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdVersion");

                    b.HasIndex("IdSoftware");

                    b.ToTable("Versions");
                });

            modelBuilder.Entity("Project.Models.Contract", b =>
                {
                    b.HasOne("Project.Models.Company", "Company")
                        .WithMany("Contracts")
                        .HasForeignKey("IdCompany")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Project.Models.Individual", "Individual")
                        .WithMany("Contracts")
                        .HasForeignKey("IdIndividual")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Project.Models.Software", "Software")
                        .WithMany("Contracts")
                        .HasForeignKey("IdSoftware")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Project.Models.Version", "Version")
                        .WithMany("Contracts")
                        .HasForeignKey("IdVersion")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Individual");

                    b.Navigation("Software");

                    b.Navigation("Version");
                });

            modelBuilder.Entity("Project.Models.Payment", b =>
                {
                    b.HasOne("Project.Models.Contract", "Contract")
                        .WithMany("Payments")
                        .HasForeignKey("IdContract")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("Project.Models.Software", b =>
                {
                    b.HasOne("Project.Models.Category", "Category")
                        .WithMany("Softwares")
                        .HasForeignKey("IdCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Project.Models.Version", b =>
                {
                    b.HasOne("Project.Models.Software", "Software")
                        .WithMany("Versions")
                        .HasForeignKey("IdSoftware")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Software");
                });

            modelBuilder.Entity("Project.Models.Category", b =>
                {
                    b.Navigation("Softwares");
                });

            modelBuilder.Entity("Project.Models.Company", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("Project.Models.Contract", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Project.Models.Individual", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("Project.Models.Software", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("Versions");
                });

            modelBuilder.Entity("Project.Models.Version", b =>
                {
                    b.Navigation("Contracts");
                });
#pragma warning restore 612, 618
        }
    }
}
