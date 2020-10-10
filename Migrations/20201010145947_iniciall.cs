using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial1.Migrations
{
    public partial class iniciall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Detalles",
                columns: table => new
                {
                    Fecha = table.Column<string>(nullable: false),
                    Tiempo = table.Column<string>(nullable: true),
                    Recurso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles", x => x.Fecha);
                });

            migrationBuilder.CreateTable(
                name: "Recursos",
                columns: table => new
                {
                    Nombre = table.Column<string>(nullable: false),
                    UsuarioPK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recursos", x => x.Nombre);
                    table.ForeignKey(
                        name: "FK_Recursos_Usuarios_UsuarioPK",
                        column: x => x.UsuarioPK,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioPK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    Titulo = table.Column<string>(nullable: false),
                    Vencimiento = table.Column<DateTime>(maxLength: 50, nullable: false),
                    Estimacion = table.Column<int>(nullable: false),
                    Responsable = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.Titulo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recursos_UsuarioPK",
                table: "Recursos",
                column: "UsuarioPK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalles");

            migrationBuilder.DropTable(
                name: "Recursos");

            migrationBuilder.DropTable(
                name: "Tareas");
        }
    }
}
