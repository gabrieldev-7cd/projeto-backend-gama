using Microsoft.EntityFrameworkCore.Migrations;

namespace DasGalaxiasAPI.Migrations
{
    public partial class AulaCompleto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "descricao",
                table: "Curso",
                type: "nvarchar(500)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descricao",
                table: "Curso");
        }
    }
}
