using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations.Database
{
    /// <inheritdoc />
    public partial class AtualizacaoNomeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ano",
                table: "Livros",
                newName: "DataPublicacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataPublicacao",
                table: "Livros",
                newName: "Ano");
        }
    }
}
