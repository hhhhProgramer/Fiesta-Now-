using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrestructure.Migrations
{
    public partial class dir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Direction",
                table: "Academias",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direction",
                table: "Academias");
        }
    }
}
