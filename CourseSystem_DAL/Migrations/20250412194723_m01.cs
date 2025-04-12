using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CourseSystem_DAL.Migrations
{
    /// <inheritdoc />
    public partial class m01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstructorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.CourseId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSessionAttendances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseSessionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSessionAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseSessionAttendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSessions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstructorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseSessions_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("3670be78-8f4d-4bbe-b612-3f628e497896"), "Mohamed", "Ziad", "01120210123" },
                    { new Guid("67fd4e60-40f4-4842-97fa-8c331f862dcf"), "Basem", "Ahmed", "01020210541" },
                    { new Guid("7cadd23b-7b0a-4dab-9d32-9c2c1570caa4"), "Ahmed", "Omer", "01020210789" },
                    { new Guid("d69770e1-71a0-4ed8-b2eb-cc54fa78e46c"), "Amr", "Mohamed", "01520210246" },
                    { new Guid("eef11cbc-ef8c-4224-bc4a-e735412d10ea"), "Ali", "Basem", "01220210456" },
                    { new Guid("f1543e8b-4418-4ca8-9d17-223e3eaf7eee"), "Omer", "Ali", "01220210897" },
                    { new Guid("f7409cb7-c20d-4f2d-a69a-e695378e8ffc"), "Ziad", "Amr", "01120210827" }
                });

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

            migrationBuilder.InsertData(
                table: "CourseSessions",
                columns: new[] { "Id", "CourseId", "Date", "InstructorId", "Title" },
                values: new object[,]
                {
                    { new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a17"), new Guid("1e33dd1b-3a4d-48f5-84c1-565170287dbf"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0e65f178-8ad3-442b-859f-48d6d964b044"), "title1" },
                    { new Guid("30308204-257c-43a3-b0a8-c18229693a15"), new Guid("1e33dd1b-3a4d-48f5-84c1-565170287dbf"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0e65f178-8ad3-442b-859f-48d6d964b044"), "title2" },
                    { new Guid("739444d1-a7c9-4842-a421-7f6e4aa00050"), new Guid("2ce2280b-8172-4045-8bdc-270794694177"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("30a2d33f-c405-4b72-a7ad-b21e630ada5e"), "title3" },
                    { new Guid("a0054941-4cfc-4e01-a786-0b6eba49e257"), new Guid("2ce2280b-8172-4045-8bdc-270794694177"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("30a2d33f-c405-4b72-a7ad-b21e630ada5e"), "title4" },
                    { new Guid("ef7d718d-c2ea-4a19-b7d8-c2a2469b0598"), new Guid("5ef659b6-d082-41d0-8f5d-984d883a3482"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b6e66f14-8e6d-4c03-9c12-753ed9e4f74d"), "title5" },
                    { new Guid("efe3251e-c1de-4fe1-89f1-be9000a3be78"), new Guid("5ef659b6-d082-41d0-8f5d-984d883a3482"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b6e66f14-8e6d-4c03-9c12-753ed9e4f74d"), "title6" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("1e33dd1b-3a4d-48f5-84c1-565170287dbf"), new Guid("3670be78-8f4d-4bbe-b612-3f628e497896") },
                    { new Guid("1e33dd1b-3a4d-48f5-84c1-565170287dbf"), new Guid("67fd4e60-40f4-4842-97fa-8c331f862dcf") },
                    { new Guid("2ce2280b-8172-4045-8bdc-270794694177"), new Guid("3670be78-8f4d-4bbe-b612-3f628e497896") },
                    { new Guid("2ce2280b-8172-4045-8bdc-270794694177"), new Guid("67fd4e60-40f4-4842-97fa-8c331f862dcf") },
                    { new Guid("5ef659b6-d082-41d0-8f5d-984d883a3482"), new Guid("3670be78-8f4d-4bbe-b612-3f628e497896") },
                    { new Guid("5ef659b6-d082-41d0-8f5d-984d883a3482"), new Guid("67fd4e60-40f4-4842-97fa-8c331f862dcf") }
                });

            migrationBuilder.InsertData(
                table: "CourseSessionAttendances",
                columns: new[] { "Id", "CourseSessionId", "Grade", "Notes", "StudentId" },
                values: new object[,]
                {
                    { new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a11"), new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a17"), 33, "note1", new Guid("3670be78-8f4d-4bbe-b612-3f628e497896") },
                    { new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a12"), new Guid("30308204-257c-43a3-b0a8-c18229693a15"), 44, "note2", new Guid("3670be78-8f4d-4bbe-b612-3f628e497896") },
                    { new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a13"), new Guid("739444d1-a7c9-4842-a421-7f6e4aa00050"), 55, "note3", new Guid("3670be78-8f4d-4bbe-b612-3f628e497896") },
                    { new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a14"), new Guid("a0054941-4cfc-4e01-a786-0b6eba49e257"), 66, "note4", new Guid("3670be78-8f4d-4bbe-b612-3f628e497896") },
                    { new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a15"), new Guid("ef7d718d-c2ea-4a19-b7d8-c2a2469b0598"), 77, "note5", new Guid("3670be78-8f4d-4bbe-b612-3f628e497896") },
                    { new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a16"), new Guid("efe3251e-c1de-4fe1-89f1-be9000a3be78"), 88, "note6", new Guid("3670be78-8f4d-4bbe-b612-3f628e497896") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentId",
                table: "Courses",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendances_CourseSessionId",
                table: "CourseSessionAttendances",
                column: "CourseSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendances_StudentId",
                table: "CourseSessionAttendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_CourseId",
                table: "CourseSessions",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_InstructorId",
                table: "CourseSessions",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments",
                column: "ManagerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DepartmentId",
                table: "Instructors",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Phone",
                table: "Instructors",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_StudentId",
                table: "StudentCourses",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessionAttendances_CourseSessions_CourseSessionId",
                table: "CourseSessionAttendances",
                column: "CourseSessionId",
                principalTable: "CourseSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessions_Instructors_InstructorId",
                table: "CourseSessions",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_ManagerId",
                table: "Departments",
                column: "ManagerId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                table: "Instructors");

            migrationBuilder.DropTable(
                name: "CourseSessionAttendances");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "CourseSessions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
