using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrestructure.Migrations
{
    public partial class fixclases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clases_Academias_AcademiaId",
                table: "Clases");

            migrationBuilder.AlterColumn<int>(
                name: "AcademiaId",
                table: "Clases",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClaseID",
                table: "Clases",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Clases_Academias_AcademiaId",
                table: "Clases",
                column: "AcademiaId",
                principalTable: "Academias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clases_Academias_AcademiaId",
                table: "Clases");

            migrationBuilder.DropColumn(
                name: "ClaseID",
                table: "Clases");

            migrationBuilder.AlterColumn<int>(
                name: "AcademiaId",
                table: "Clases",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Clases_Academias_AcademiaId",
                table: "Clases",
                column: "AcademiaId",
                principalTable: "Academias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
