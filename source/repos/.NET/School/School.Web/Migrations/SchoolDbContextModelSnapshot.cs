﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Web.Infrastructure;

#nullable disable

namespace School.Web.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("School.Web.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("41a66753-29e7-49c7-92b4-4e8ca2b93719"),
                            Credits = 3,
                            Title = "Chemistry"
                        },
                        new
                        {
                            Id = new Guid("6610bf88-4bf4-4acc-a8b3-863b30897752"),
                            Credits = 4,
                            Title = "Calculus"
                        },
                        new
                        {
                            Id = new Guid("c6507994-4723-4b5b-8cbd-887495a39054"),
                            Credits = 4,
                            Title = "Literature"
                        });
                });

            modelBuilder.Entity("School.Web.Models.Enrollment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6eea515a-5e45-4760-9311-75b86a94cc4d"),
                            CourseId = new Guid("41a66753-29e7-49c7-92b4-4e8ca2b93719"),
                            Grade = 11,
                            StudentId = new Guid("52c94dba-8e92-4f3a-9ba3-de01988a58ce")
                        },
                        new
                        {
                            Id = new Guid("6fb15d30-e22d-44ef-b0ea-489d67912f83"),
                            CourseId = new Guid("6610bf88-4bf4-4acc-a8b3-863b30897752"),
                            Grade = 8,
                            StudentId = new Guid("52c94dba-8e92-4f3a-9ba3-de01988a58ce")
                        },
                        new
                        {
                            Id = new Guid("2144c285-25d1-4176-ae34-26898bd3e749"),
                            CourseId = new Guid("c6507994-4723-4b5b-8cbd-887495a39054"),
                            Grade = 15,
                            StudentId = new Guid("52c94dba-8e92-4f3a-9ba3-de01988a58ce")
                        },
                        new
                        {
                            Id = new Guid("18b7ad25-e104-4c91-aed9-100e8c57407b"),
                            CourseId = new Guid("41a66753-29e7-49c7-92b4-4e8ca2b93719"),
                            Grade = 8,
                            StudentId = new Guid("43321c6e-6cf0-486a-9a5a-425e036994d0")
                        },
                        new
                        {
                            Id = new Guid("ded2524b-0f8d-4ff4-8adc-206c0bf8d64a"),
                            CourseId = new Guid("6610bf88-4bf4-4acc-a8b3-863b30897752"),
                            Grade = 8,
                            StudentId = new Guid("43321c6e-6cf0-486a-9a5a-425e036994d0")
                        },
                        new
                        {
                            Id = new Guid("58cc545c-3fb5-4b1d-aaa2-8d3b07395509"),
                            CourseId = new Guid("c6507994-4723-4b5b-8cbd-887495a39054"),
                            Grade = 12,
                            StudentId = new Guid("43321c6e-6cf0-486a-9a5a-425e036994d0")
                        });
                });

            modelBuilder.Entity("School.Web.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("52c94dba-8e92-4f3a-9ba3-de01988a58ce"),
                            FirstName = "John",
                            LastName = "Doe",
                            StartedOn = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("43321c6e-6cf0-486a-9a5a-425e036994d0"),
                            FirstName = "Jane",
                            LastName = "Doe",
                            StartedOn = new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("School.Web.Models.Enrollment", b =>
                {
                    b.HasOne("School.Web.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Web.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("School.Web.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("School.Web.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
