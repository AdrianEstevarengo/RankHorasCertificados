using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RankHorasCertificados.Migrations
{
    public partial class CursoCargaHoraria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Usuario",
                newName: "Nome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuario",
                newName: "Name");
        }
    }
}
