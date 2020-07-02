using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Becas_Escolar.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    CURP = table.Column<string>(nullable: true),
                    Nacionalidad = table.Column<string>(nullable: true),
                    Fecha_nacimiento = table.Column<DateTime>(nullable: false),
                    Genero = table.Column<string>(nullable: true),
                    Discapacidad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumno");
        }
    }
}
