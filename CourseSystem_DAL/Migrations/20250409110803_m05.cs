using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CourseSystem_DAL.Migrations
{
    /// <inheritdoc />
    public partial class m05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Location", "ManagerId", "Name" },
                values: new object[,]
                {
                    { new Guid("045e90a9-bd08-45ae-80c7-fa8ee939fd74"), null, new Guid("0e65f178-8ad3-442b-859f-48d6d964b044"), "SD" },
                    { new Guid("c11ea3d8-7da5-44bd-a313-e1a6fbafad79"), null, new Guid("30a2d33f-c405-4b72-a7ad-b21e630ada5e"), "UI" },
                    { new Guid("cb84409a-44b6-49fa-8a67-92ae33862119"), null, new Guid("8c8e5e8e-2210-4c96-9a78-51f66471627b"), "Network" },
                    { new Guid("d5b7c05f-4fbf-44c3-b181-2176aa8ea9e2"), null, new Guid("a7405fe2-f9ff-488c-937b-ff60e3e9c24d"), "Mobile" },
                    { new Guid("d67ae4ea-6fb4-4dbd-af73-90192db76b5a"), null, new Guid("b6e66f14-8e6d-4c03-9c12-753ed9e4f74d"), "Cloud" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("045e90a9-bd08-45ae-80c7-fa8ee939fd74"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c11ea3d8-7da5-44bd-a313-e1a6fbafad79"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("cb84409a-44b6-49fa-8a67-92ae33862119"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d5b7c05f-4fbf-44c3-b181-2176aa8ea9e2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d67ae4ea-6fb4-4dbd-af73-90192db76b5a"));
        }
    }
}
