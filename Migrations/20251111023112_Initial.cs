using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace final.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Fname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Mname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Lname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Province = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Unit = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Inventory = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Unit = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    City = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Inventory", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Plushies", 10, "Tom Plushie", 30m },
                    { 2, "Plushies", 10, "Jerry Plushie", 30m },
                    { 3, "Plushies", 10, "Nibble Plushie", 25m },
                    { 4, "Figurines", 10, "Tom Figurine", 40m },
                    { 5, "Figurines", 10, "Jerry Figurine", 40m },
                    { 6, "Figurines", 10, "Nibble Figurine", 35m },
                    { 7, "Figurines", 10, "Spike Figurine", 30m },
                    { 8, "Poster", 10, "Tom and Jerry Poster no.1", 15m },
                    { 9, "Poster", 10, "Tom and Jerry Poster no.2", 15m },
                    { 10, "Poster", 10, "Tom and Jerry Poster no.3", 15m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProductId",
                table: "Order",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
