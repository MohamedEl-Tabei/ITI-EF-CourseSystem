using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CourseSystem_DAL.Migrations
{
    /// <inheritdoc />
    public partial class m04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "DepartmentId", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("0e65f178-8ad3-442b-859f-48d6d964b044"), null, "Mohamed", "Ziad", "01120210123" },
                    { new Guid("30a2d33f-c405-4b72-a7ad-b21e630ada5e"), null, "Basem", "Ahmed", "01020210541" },
                    { new Guid("8c8e5e8e-2210-4c96-9a78-51f66471627b"), null, "Ahmed", "Omer", "01020210789" },
                    { new Guid("a7405fe2-f9ff-488c-937b-ff60e3e9c24d"), null, "Amr", "Mohamed", "01520210246" },
                    { new Guid("b6e66f14-8e6d-4c03-9c12-753ed9e4f74d"), null, "Ali", "Basem", "01220210456" },
                    { new Guid("c8b09a7f-0c3a-4a97-b586-55f23cfed9a6"), null, "Omer", "Ali", "01220210897" },
                    { new Guid("e44c2c5d-9de9-45b4-814a-03169fc4edd1"), null, "Ziad", "Amr", "01120210827" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("0e65f178-8ad3-442b-859f-48d6d964b044"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("30a2d33f-c405-4b72-a7ad-b21e630ada5e"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("8c8e5e8e-2210-4c96-9a78-51f66471627b"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("a7405fe2-f9ff-488c-937b-ff60e3e9c24d"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("b6e66f14-8e6d-4c03-9c12-753ed9e4f74d"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("c8b09a7f-0c3a-4a97-b586-55f23cfed9a6"));

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: new Guid("e44c2c5d-9de9-45b4-814a-03169fc4edd1"));
        }
    }
}
