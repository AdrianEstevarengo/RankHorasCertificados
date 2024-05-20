using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RankHorasCertificados.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Externo = table.Column<bool>(type: "bit", nullable: false),
                    Interno = table.Column<bool>(type: "bit", nullable: false),
                    Duracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Matricula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Setor = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Curso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Matricula);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
