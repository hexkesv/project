using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace final.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Dessert", "Cherry Toast with Cream cheese", 7m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Dessert", "Jelly Cat", 7m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Dessert", "Lemon and Blueberry Cheesecake", 8m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Dessert", "Orange Cat", 2m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Dessert", "Raspberry Macaroon", 2m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Dessert", "Ube Macaroon", 2m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Drink", "Blue Milk tea", 6m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Drink", "Coffee", 6m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Drink", "Strawberry Milk", 6m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Cake", "Chery Burnt-Basque Cheesecake", 30m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "ImagePath", "Inventory", "Name", "Price" },
                values: new object[,]
                {
                    { 11, "Cake", null, 10, "Marshmello Cake", 20m },
                    { 12, "Cake", null, 10, "Mouse Cake", 25m },
                    { 13, "Cake", null, 10, "Ratatouille Cake", 22m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Plushies", "Tom Plushie", 30m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Plushies", "Jerry Plushie", 30m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Plushies", "Nibble Plushie", 25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Figurines", "Tom Figurine", 40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Figurines", "Jerry Figurine", 40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Figurines", "Nibble Figurine", 35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Figurines", "Spike Figurine", 30m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Poster", "Tom and Jerry Poster no.1", 15m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Poster", "Tom and Jerry Poster no.2", 15m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Poster", "Tom and Jerry Poster no.3", 15m });
        }
    }
}
