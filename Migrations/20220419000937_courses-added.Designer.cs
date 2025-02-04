﻿// <auto-generated />
using MVC4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC4.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20220419000937_courses-added")]
    partial class coursesadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CourseDepartment", b =>
                {
                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<int>("coursesId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsId", "coursesId");

                    b.HasIndex("coursesId");

                    b.ToTable("CourseDepartment");
                });

            modelBuilder.Entity("MVC4.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("MVC4.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("MVC4.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<int>("deptID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("deptID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CourseDepartment", b =>
                {
                    b.HasOne("MVC4.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC4.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("coursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC4.Models.Student", b =>
                {
                    b.HasOne("MVC4.Models.Department", "dept")
                        .WithMany("students")
                        .HasForeignKey("deptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dept");
                });

            modelBuilder.Entity("MVC4.Models.Department", b =>
                {
                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}
