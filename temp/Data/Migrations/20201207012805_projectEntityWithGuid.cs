using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace temp.Data.Migrations
{
    public partial class projectEntityWithGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Error");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "ThingE");

            migrationBuilder.DropTable(
                name: "Viewed");

            migrationBuilder.DropTable(
                name: "ThingA");

            migrationBuilder.DropTable(
                name: "ThingD");

            migrationBuilder.DropTable(
                name: "ThingB");

            migrationBuilder.DropTable(
                name: "ThingC");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
