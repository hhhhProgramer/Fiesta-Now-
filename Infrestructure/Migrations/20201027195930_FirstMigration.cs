using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrestructure.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Correo = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Rol = table.Column<string>(nullable: true),
                    Estatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Academias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Longitud = table.Column<int>(nullable: false),
                    Latitud = table.Column<int>(nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    CuentaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Academias_Cuentas_CuentaID",
                        column: x => x.CuentaID,
                        principalTable: "Cuentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    CuentaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Cuentas_CuentaID",
                        column: x => x.CuentaID,
                        principalTable: "Cuentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suscripcions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inicio = table.Column<DateTime>(nullable: false),
                    Vencimiento = table.Column<DateTime>(nullable: false),
                    Detalles = table.Column<string>(nullable: true),
                    CuentaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suscripcions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suscripcions_Cuentas_CuentaId",
                        column: x => x.CuentaId,
                        principalTable: "Cuentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CodigoBailes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    AcademiaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodigoBailes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CodigoBailes_Academias_AcademiaId",
                        column: x => x.AcademiaId,
                        principalTable: "Academias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlumnosMax = table.Column<int>(nullable: false),
                    CodigoBaileID = table.Column<int>(nullable: false),
                    AcademiaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clases_Academias_AcademiaId",
                        column: x => x.AcademiaId,
                        principalTable: "Academias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clases_CodigoBailes_CodigoBaileID",
                        column: x => x.CodigoBaileID,
                        principalTable: "CodigoBailes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clases_Suscripciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaseID = table.Column<int>(nullable: false),
                    SuscripcionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases_Suscripciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clases_Suscripciones_Clases_ClaseID",
                        column: x => x.ClaseID,
                        principalTable: "Clases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clases_Suscripciones_Suscripcions_SuscripcionID",
                        column: x => x.SuscripcionID,
                        principalTable: "Suscripcions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apertura = table.Column<DateTime>(nullable: false),
                    Cierre = table.Column<DateTime>(nullable: false),
                    Dia = table.Column<string>(nullable: true),
                    ClaseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horarios_Clases_ClaseId",
                        column: x => x.ClaseId,
                        principalTable: "Clases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Academias_CuentaID",
                table: "Academias",
                column: "CuentaID");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_AcademiaId",
                table: "Clases",
                column: "AcademiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_CodigoBaileID",
                table: "Clases",
                column: "CodigoBaileID");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_Suscripciones_ClaseID",
                table: "Clases_Suscripciones",
                column: "ClaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_Suscripciones_SuscripcionID",
                table: "Clases_Suscripciones",
                column: "SuscripcionID");

            migrationBuilder.CreateIndex(
                name: "IX_CodigoBailes_AcademiaId",
                table: "CodigoBailes",
                column: "AcademiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_CuentaID",
                table: "Estudiantes",
                column: "CuentaID");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_ClaseId",
                table: "Horarios",
                column: "ClaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Suscripcions_CuentaId",
                table: "Suscripcions",
                column: "CuentaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clases_Suscripciones");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Suscripcions");

            migrationBuilder.DropTable(
                name: "Clases");

            migrationBuilder.DropTable(
                name: "CodigoBailes");

            migrationBuilder.DropTable(
                name: "Academias");

            migrationBuilder.DropTable(
                name: "Cuentas");
        }
    }
}
