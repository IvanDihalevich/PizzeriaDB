using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizzeria.Core.Migrations
{
    /// <inheritdoc />
    public partial class PricesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DishPrices",
                columns: table => new
                {
                    DishesId = table.Column<int>(type: "int", nullable: false),
                    PricesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishPrices", x => new { x.DishesId, x.PricesId });
                    table.ForeignKey(
                        name: "FK_DishPrices_Dishes_DishesId",
                        column: x => x.DishesId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishPrices_Prices_PricesId",
                        column: x => x.PricesId,
                        principalTable: "Prices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DishPrices_PricesId",
                table: "DishPrices",
                column: "PricesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishPrices");

            migrationBuilder.DropTable(
                name: "Prices");
        }
    }
}
