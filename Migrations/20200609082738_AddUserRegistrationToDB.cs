using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserRegistration.Migrations
{
    public partial class AddUserRegistrationToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRegistration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    UserName = table.Column<string>(maxLength: 25, nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false),
                    Location = table.Column<string>(maxLength: 20, nullable: true),
                    MobileNo = table.Column<long>(maxLength: 10, nullable: true),
                    DOB = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRegistration", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRegistration");
        }
    }
}
