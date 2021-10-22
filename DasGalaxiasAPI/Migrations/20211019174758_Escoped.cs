using Microsoft.EntityFrameworkCore.Migrations;

namespace DasGalaxiasAPI.Migrations
{
    public partial class Escoped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescricaoAula1",
                table: "Curso",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescricaoAula2",
                table: "Curso",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkAula1",
                table: "Curso",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkAula2",
                table: "Curso",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TituloAula1",
                table: "Curso",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TituloAula2",
                table: "Curso",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescricaoAula1",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "DescricaoAula2",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "LinkAula1",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "LinkAula2",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "TituloAula1",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "TituloAula2",
                table: "Curso");
        }
    }
}
