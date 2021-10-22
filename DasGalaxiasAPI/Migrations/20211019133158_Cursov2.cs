using Microsoft.EntityFrameworkCore.Migrations;

namespace DasGalaxiasAPI.Migrations
{
    public partial class Cursov2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Curso",
                newName: "Descricao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Curso",
                newName: "descricao");
        }
    }
}
