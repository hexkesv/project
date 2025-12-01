using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final.Migrations
{
    /// <inheritdoc />
    public partial class AddProductImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Products_ProductId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ProductId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Order",
                newName: "TotalPrice");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Products",
                type: "TEXT",
                maxLength: 255,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "ImagePath",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Order",
                newName: "Price");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Order",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProductId",
                table: "Order",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Products_ProductId",
                table: "Order",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
