using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizzeria.Core.Migrations
{
    /// <inheritdoc />
    public partial class OrdersDishesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders_Dishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    DishId = table.Column<int>(type: "int", nullable: false),
                    Dish_count = table.Column<int>(type: "int", nullable: false),
                    Current_price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders_Dishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Dishes_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Dishes_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Dishes_DishId",
                table: "Orders_Dishes",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Dishes_OrdersId",
                table: "Orders_Dishes",
                column: "OrdersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders_Dishes");
        }
    }
}
