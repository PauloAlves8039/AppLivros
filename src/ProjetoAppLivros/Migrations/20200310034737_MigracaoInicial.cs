using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoAppLivros.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LIV_LIVRO",
                columns: table => new
                {
                    LIV_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LIV_TITULO = table.Column<string>(maxLength: 50, nullable: false),
                    LIV_AUTOR = table.Column<string>(maxLength: 50, nullable: false),
                    LIV_GENERO = table.Column<string>(maxLength: 50, nullable: false),
                    LIV_LANCAMENTO = table.Column<DateTime>(nullable: false),
                    LIV_EDITORA = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIV_LIVRO", x => x.LIV_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LIV_LIVRO");
        }
    }
}
