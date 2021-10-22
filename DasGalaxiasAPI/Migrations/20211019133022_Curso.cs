using Microsoft.EntityFrameworkCore.Migrations;

namespace DasGalaxiasAPI.Migrations
{
    public partial class Curso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AulaId",
                table: "Curso",
                newName: "CursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "Curso",
                newName: "AulaId");
        }
    }
}
