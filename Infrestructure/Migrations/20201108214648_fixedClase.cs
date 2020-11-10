using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrestructure.Migrations
{
    public partial class fixedClase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Clases",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Clases");
        }
    }
}
