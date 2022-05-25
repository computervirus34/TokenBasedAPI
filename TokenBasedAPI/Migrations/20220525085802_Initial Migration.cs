using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TokenBasedAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalIDNumber = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    EmployeeName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    LoginID = table.Column<string>(unicode: false, maxLength: 256, nullable: true),
                    JobTitle = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BirthDate = table.Column<DateTime>(unicode: false, nullable: false),
                    MaritalStatus = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Gender = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    HireDate = table.Column<DateTime>(unicode: false, nullable: false),
                    VacationHours = table.Column<short>(unicode: false, nullable: false),
                    SickLeaveHours = table.Column<short>(unicode: false, nullable: false),
                    RowGuid = table.Column<Guid>(unicode: false, maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DisplayName = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    UserName = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "UserInfo");
        }
    }
}
