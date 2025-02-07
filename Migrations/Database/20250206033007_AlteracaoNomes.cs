using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations.Database
{
    /// <inheritdoc />
    public partial class AlteracaoNomes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "categoria",
                table: "Livros",
                newName: "Categoria");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Livros",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Categoria",
                table: "Livros",
                newName: "categoria");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Livros",
                newName: "Id");
        }
    }
}
