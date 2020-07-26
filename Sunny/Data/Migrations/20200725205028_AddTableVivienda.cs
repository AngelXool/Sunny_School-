using Microsoft.EntityFrameworkCore.Migrations;

namespace Sunny.Data.Migrations
{
    public partial class AddTableVivienda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Info_Vivienda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Piezas_Casa = table.Column<long>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    Servicios = table.Column<string>(nullable: true),
                    Construccion = table.Column<string>(nullable: true),
                    Estatus = table.Column<string>(nullable: true),
                    Mobiliario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info_Vivienda", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Info_Vivienda");
        }
    }
}
