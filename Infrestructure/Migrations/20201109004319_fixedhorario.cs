using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrestructure.Migrations
{
    public partial class fixedhorario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horarios_Clases_ClaseId",
                table: "Horarios");

            migrationBuilder.AlterColumn<int>(
                name: "ClaseId",
                table: "Horarios",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Horarios_Clases_ClaseId",
                table: "Horarios",
                column: "ClaseId",
                principalTable: "Clases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horarios_Clases_ClaseId",
                table: "Horarios");

            migrationBuilder.AlterColumn<int>(
                name: "ClaseId",
                table: "Horarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Horarios_Clases_ClaseId",
                table: "Horarios",
                column: "ClaseId",
                principalTable: "Clases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
