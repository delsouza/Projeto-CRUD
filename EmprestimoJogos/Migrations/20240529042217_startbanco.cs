using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmprestimoJogos.Migrations
{
    /// <inheritdoc />
    public partial class startbanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaRecebe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaFornece = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JogoEmprestado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprestimoData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprestimos");
        }
    }
}
