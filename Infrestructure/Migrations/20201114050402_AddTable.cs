using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrestructure.Migrations
{
    public partial class AddTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodigoBailes_Academias_AcademiaId",
                table: "CodigoBailes");

            migrationBuilder.DropIndex(
                name: "IX_CodigoBailes_AcademiaId",
                table: "CodigoBailes");

            migrationBuilder.DropColumn(
                name: "AcademiaId",
                table: "CodigoBailes");

            migrationBuilder.CreateTable(
                name: "CodigoBailes_Academias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoBaileId = table.Column<int>(nullable: false),
                    AcademiaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodigoBailes_Academias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CodigoBailes_Academias_Academias_AcademiaId",
                        column: x => x.AcademiaId,
                        principalTable: "Academias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CodigoBailes_Academias_CodigoBailes_CodigoBaileId",
                        column: x => x.CodigoBaileId,
                        principalTable: "CodigoBailes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CodigoBailes_Academias_AcademiaId",
                table: "CodigoBailes_Academias",
                column: "AcademiaId");

            migrationBuilder.CreateIndex(
                name: "IX_CodigoBailes_Academias_CodigoBaileId",
                table: "CodigoBailes_Academias",
                column: "CodigoBaileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodigoBailes_Academias");

            migrationBuilder.AddColumn<int>(
                name: "AcademiaId",
                table: "CodigoBailes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CodigoBailes_AcademiaId",
                table: "CodigoBailes",
                column: "AcademiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_CodigoBailes_Academias_AcademiaId",
                table: "CodigoBailes",
                column: "AcademiaId",
                principalTable: "Academias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
