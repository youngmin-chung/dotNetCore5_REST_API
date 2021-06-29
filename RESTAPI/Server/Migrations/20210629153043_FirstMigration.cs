using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RESTAPI.Server.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBrith = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Payroll" },
                    { 4, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBrith", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "harry@hogwarts.com", "Harry", 0, "Potter", "images/hp.png" },
                    { 2, new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "hermione@hogwarts.com", "Hermione", 1, "Granger", "images/hg.jpg" },
                    { 3, new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "ron@hogwarts.com", "Ron", 0, "Weasley", "images/rw.png" },
                    { 4, new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "luna@hogwarts.com", "Luna", 1, "Lovegood", "images/luluv.png" },
                    { 5, new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "rub@hogwarts.com", "Rubeus", 0, "Hagrid", "images/rh.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
