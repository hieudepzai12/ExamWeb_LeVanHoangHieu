﻿// <auto-generated />
using ExamWeb_LeVanHoangHieu.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamWeb_LeVanHoangHieu.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250611013033_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExamWeb_LeVanHoangHieu.Models.DiaNhac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("GiaBan")
                        .HasColumnType("float");

                    b.Property<string>("NgheSi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<bool>("TrongNuoc")
                        .HasColumnType("bit");

                    b.Property<string>("TuaCD")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("DiaNhacs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GiaBan = 150000.0,
                            NgheSi = "Nghệ sĩ A",
                            SoLuong = 3,
                            TrongNuoc = true,
                            TuaCD = "Album 1"
                        },
                        new
                        {
                            Id = 2,
                            GiaBan = 200000.0,
                            NgheSi = "Nghệ sĩ B",
                            SoLuong = 6,
                            TrongNuoc = false,
                            TuaCD = "Album 2"
                        },
                        new
                        {
                            Id = 3,
                            GiaBan = 100000.0,
                            NgheSi = "Nghệ sĩ C",
                            SoLuong = 10,
                            TrongNuoc = true,
                            TuaCD = "Album 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
