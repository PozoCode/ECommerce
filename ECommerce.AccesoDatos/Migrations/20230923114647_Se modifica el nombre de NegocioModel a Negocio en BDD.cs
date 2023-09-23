using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class SemodificaelnombredeNegocioModelaNegocioenBDD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NegocioModel",
                table: "NegocioModel");

            migrationBuilder.RenameTable(
                name: "NegocioModel",
                newName: "Negocio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Negocio",
                table: "Negocio",
                column: "NegocioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Negocio",
                table: "Negocio");

            migrationBuilder.RenameTable(
                name: "Negocio",
                newName: "NegocioModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NegocioModel",
                table: "NegocioModel",
                column: "NegocioId");
        }
    }
}
