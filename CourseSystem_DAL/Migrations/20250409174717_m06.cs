﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSystem_DAL.Migrations
{
    /// <inheritdoc />
    public partial class m06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Phone",
                table: "Instructors",
                column: "Phone",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Instructors_Phone",
                table: "Instructors");
        }
    }
}
