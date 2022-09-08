using Microsoft.EntityFrameworkCore.Migrations;

namespace KevinRuizAPI.Migrations
{
    public partial class TablaHumano : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Humanos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    Altura = table.Column<double>(nullable: false),
                    Peso = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Humanos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Humanos");
        }
    }
}
