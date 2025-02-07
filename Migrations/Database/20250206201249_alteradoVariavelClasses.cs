using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations.Database
{
    /// <inheritdoc />
    public partial class alteradoVariavelClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Livros",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "DataPublicacao",
                table: "Livros",
                newName: "dataPublicacao");

            migrationBuilder.RenameColumn(
                name: "Categoria",
                table: "Livros",
                newName: "categoria");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Livros",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Livros",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "dataPublicacao",
                table: "Livros",
                newName: "DataPublicacao");

            migrationBuilder.RenameColumn(
                name: "categoria",
                table: "Livros",
                newName: "Categoria");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Livros",
                newName: "ID");
        }
    }
}
