using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KJTGroup.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class Cargo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CargoId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CargoId",
                table: "Products",
                column: "CargoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Cargos_CargoId",
                table: "Products",
                column: "CargoId",
                principalTable: "Cargos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Cargos_CargoId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropIndex(
                name: "IX_Products_CargoId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CargoId",
                table: "Products");
        }
    }
}
