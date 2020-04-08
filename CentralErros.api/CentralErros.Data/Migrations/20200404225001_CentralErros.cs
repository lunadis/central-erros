using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CentralErros.Data.Migrations
{
    public partial class CentralErros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Erro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(300)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Erro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Login = table.Column<string>(type: "varchar(20)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioErros",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false),
                    IdErro = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioErros", x => new { x.IdErro, x.IdUsuario });
                    table.ForeignKey(
                        name: "FK_UsuarioErros_Erro_IdErro",
                        column: x => x.IdErro,
                        principalTable: "Erro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioErros_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioErros_IdUsuario",
                table: "UsuarioErros",
                column: "IdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioErros");

            migrationBuilder.DropTable(
                name: "Erro");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
