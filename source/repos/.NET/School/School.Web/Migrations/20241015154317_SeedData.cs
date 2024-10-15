using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Title" },
                values: new object[,]
                {
                    { new Guid("41a66753-29e7-49c7-92b4-4e8ca2b93719"), 3, "Chemistry" },
                    { new Guid("6610bf88-4bf4-4acc-a8b3-863b30897752"), 4, "Calculus" },
                    { new Guid("c6507994-4723-4b5b-8cbd-887495a39054"), 4, "Literature" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LastName", "StartedOn" },
                values: new object[,]
                {
                    { new Guid("43321c6e-6cf0-486a-9a5a-425e036994d0"), "Jane", "Doe", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52c94dba-8e92-4f3a-9ba3-de01988a58ce"), "John", "Doe", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { new Guid("18b7ad25-e104-4c91-aed9-100e8c57407b"), new Guid("41a66753-29e7-49c7-92b4-4e8ca2b93719"), 8, new Guid("43321c6e-6cf0-486a-9a5a-425e036994d0") },
                    { new Guid("2144c285-25d1-4176-ae34-26898bd3e749"), new Guid("c6507994-4723-4b5b-8cbd-887495a39054"), 15, new Guid("52c94dba-8e92-4f3a-9ba3-de01988a58ce") },
                    { new Guid("58cc545c-3fb5-4b1d-aaa2-8d3b07395509"), new Guid("c6507994-4723-4b5b-8cbd-887495a39054"), 12, new Guid("43321c6e-6cf0-486a-9a5a-425e036994d0") },
                    { new Guid("6eea515a-5e45-4760-9311-75b86a94cc4d"), new Guid("41a66753-29e7-49c7-92b4-4e8ca2b93719"), 11, new Guid("52c94dba-8e92-4f3a-9ba3-de01988a58ce") },
                    { new Guid("6fb15d30-e22d-44ef-b0ea-489d67912f83"), new Guid("6610bf88-4bf4-4acc-a8b3-863b30897752"), 8, new Guid("52c94dba-8e92-4f3a-9ba3-de01988a58ce") },
                    { new Guid("ded2524b-0f8d-4ff4-8adc-206c0bf8d64a"), new Guid("6610bf88-4bf4-4acc-a8b3-863b30897752"), 8, new Guid("43321c6e-6cf0-486a-9a5a-425e036994d0") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("18b7ad25-e104-4c91-aed9-100e8c57407b"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("2144c285-25d1-4176-ae34-26898bd3e749"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("58cc545c-3fb5-4b1d-aaa2-8d3b07395509"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("6eea515a-5e45-4760-9311-75b86a94cc4d"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("6fb15d30-e22d-44ef-b0ea-489d67912f83"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("ded2524b-0f8d-4ff4-8adc-206c0bf8d64a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("41a66753-29e7-49c7-92b4-4e8ca2b93719"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6610bf88-4bf4-4acc-a8b3-863b30897752"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c6507994-4723-4b5b-8cbd-887495a39054"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("43321c6e-6cf0-486a-9a5a-425e036994d0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("52c94dba-8e92-4f3a-9ba3-de01988a58ce"));
        }
    }
}
