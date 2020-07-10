using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sunny.Data.Migrations
{
    public partial class addTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Info_Economica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingresos_Mensuales = table.Column<long>(nullable: false),
                    Gasto_Alimentacion = table.Column<long>(nullable: false),
                    Gasto_Escolar = table.Column<long>(nullable: false),
                    Gasto_Vivienda = table.Column<long>(nullable: false),
                    Gasto_Servicios = table.Column<long>(nullable: false),
                    Gasto_Transporte = table.Column<long>(nullable: false),
                    Otros = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info_Economica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Info_Escolar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Nivel_Escolar = table.Column<string>(nullable: true),
                    Grado_Escolar = table.Column<string>(nullable: true),
                    Nombre_Tutor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info_Escolar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Info_Madre",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Madre = table.Column<string>(nullable: false),
                    CURP = table.Column<string>(nullable: false),
                    Nacionalidad = table.Column<string>(nullable: false),
                    Fecha_nacimiento = table.Column<DateTime>(nullable: false),
                    Ocupacion = table.Column<string>(nullable: false),
                    Ingresos = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info_Madre", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Info_Padre",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Padre = table.Column<string>(nullable: false),
                    CURP = table.Column<string>(nullable: false),
                    Nacionalidad = table.Column<string>(nullable: false),
                    Fecha_nacimiento = table.Column<DateTime>(nullable: false),
                    Ocupacion = table.Column<string>(nullable: false),
                    Ingresos = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info_Padre", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Info_Economica");

            migrationBuilder.DropTable(
                name: "Info_Escolar");

            migrationBuilder.DropTable(
                name: "Info_Madre");

            migrationBuilder.DropTable(
                name: "Info_Padre");
        }
    }
}
