using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CourseSystem_DAL.Migrations
{
    /// <inheritdoc />
    public partial class m09 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "DepartmentId", "Duration", "InstructorId", "Name" },
                values: new object[,]
                {
                    { new Guid("1e33dd1b-3a4d-48f5-84c1-565170287dbf"), new Guid("045e90a9-bd08-45ae-80c7-fa8ee939fd74"), 4, new Guid("0e65f178-8ad3-442b-859f-48d6d964b044"), "C#" },
                    { new Guid("2ce2280b-8172-4045-8bdc-270794694177"), new Guid("c11ea3d8-7da5-44bd-a313-e1a6fbafad79"), 5, new Guid("30a2d33f-c405-4b72-a7ad-b21e630ada5e"), "Java 0Script" },
                    { new Guid("5ef659b6-d082-41d0-8f5d-984d883a3482"), new Guid("cb84409a-44b6-49fa-8a67-92ae33862119"), 6, new Guid("8c8e5e8e-2210-4c96-9a78-51f66471627b"), "Secuirety" },
                    { new Guid("f78d5fdf-66b7-44be-b9f2-1e42be682a74"), new Guid("d5b7c05f-4fbf-44c3-b181-2176aa8ea9e2"), 7, new Guid("a7405fe2-f9ff-488c-937b-ff60e3e9c24d"), "Flutter" },
                    { new Guid("fe17271a-1f45-4a17-b661-30fc9b377f98"), new Guid("d67ae4ea-6fb4-4dbd-af73-90192db76b5a"), 8, new Guid("b6e66f14-8e6d-4c03-9c12-753ed9e4f74d"), "Azure" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1e33dd1b-3a4d-48f5-84c1-565170287dbf"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2ce2280b-8172-4045-8bdc-270794694177"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5ef659b6-d082-41d0-8f5d-984d883a3482"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f78d5fdf-66b7-44be-b9f2-1e42be682a74"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("fe17271a-1f45-4a17-b661-30fc9b377f98"));
        }
    }
}
