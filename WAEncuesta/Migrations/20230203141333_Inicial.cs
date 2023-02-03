using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WAEncuesta.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbCuestionario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    preguntauno = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    preguntados = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    preguntatres = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    preguntacuatro = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    preguntacinco = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    preguntaseis = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    preguntasiete = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    preguntaocho = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    preguntanueve = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    preguntadiez = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCuestionario", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbCuestionario");
        }
    }
}
