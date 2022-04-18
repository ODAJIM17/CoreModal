using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreModal.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    ContactEmail = table.Column<string>(type: "VARCHAR(70)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    City = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    State = table.Column<string>(type: "VARCHAR(2)", nullable: false),
                    ZipCode = table.Column<string>(type: "VARCHAR(6)", nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InputBy = table.Column<string>(type: "VARCHAR(70)", nullable: true),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "VARCHAR(70)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
