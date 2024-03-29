﻿// <auto-generated />
using System;
using BankruptcyTask.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankruptcyTask.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BankruptcyTask.Domain.Entity.Debtor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ArbitratorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ArbitratorId");

                    b.ToTable("Debtors");
                });

            modelBuilder.Entity("BankruptcyTask.Domain.Estate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DebtorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsRealize")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DebtorId");

                    b.ToTable("Estates");
                });

            modelBuilder.Entity("BankruptcyTask.Models.Entity.Arbitrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Arbitrators");
                });

            modelBuilder.Entity("BankruptcyTask.Domain.Entity.Debtor", b =>
                {
                    b.HasOne("BankruptcyTask.Models.Entity.Arbitrator", "Arbitrator")
                        .WithMany()
                        .HasForeignKey("ArbitratorId");

                    b.Navigation("Arbitrator");
                });

            modelBuilder.Entity("BankruptcyTask.Domain.Estate", b =>
                {
                    b.HasOne("BankruptcyTask.Domain.Entity.Debtor", "Debtor")
                        .WithMany("EstateList")
                        .HasForeignKey("DebtorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Debtor");
                });

            modelBuilder.Entity("BankruptcyTask.Domain.Entity.Debtor", b =>
                {
                    b.Navigation("EstateList");
                });
#pragma warning restore 612, 618
        }
    }
}
