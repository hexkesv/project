using final.Models;
using Microsoft.EntityFrameworkCore;

namespace final.Data
{
    public class ProductContext : DbContext  // renamed to match filename
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }  // DbSet for products

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Cherry Toast with Cream cheese",
                    Category = "Dessert",
                    Price = 7m,
                    Inventory = 10,
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Jelly Cat",
                    Category = "Dessert",
                    Price = 7m,
                    Inventory = 10,
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Lemon and Blueberry Cheesecake",
                    Category = "Dessert",
                    Price = 8m,
                    Inventory = 10
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Orange Cat",
                    Category = "Dessert",
                    Price = 2m,
                    Inventory = 10,
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Raspberry Macaroon",
                    Category = "Dessert",
                    Price = 2m,
                    Inventory = 10,
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Ube Macaroon",
                    Category = "Dessert",
                    Price = 2m,
                    Inventory = 10,
                },
                new Product
                {
                    ProductId = 7,
                    Name = "Blue Milk tea",
                    Category = "Drink",
                    Price = 6m,
                    Inventory = 10,
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Coffee",
                    Category = "Drink",
                    Price = 6m,
                    Inventory = 10,
                },
                new Product
                {
                    ProductId = 9,
                    Name = "Strawberry Milk",
                    Category = "Drink",
                    Price = 6m,
                    Inventory = 10
                },
                new Product
                {
                    ProductId = 10,
                    Name = "Chery Burnt-Basque Cheesecake",
                    Category = "Cake",
                    Price = 30m,
                    Inventory = 10,
                },
                new Product
                {
                    ProductId = 11,
                    Name = "Marshmello Cake",
                    Category = "Cake",
                    Price = 20m,
                    Inventory = 10,
                },
                new Product
                {
                    ProductId = 12,
                    Name = "Mouse Cake",
                    Category = "Cake",
                    Price = 25m,
                    Inventory = 10,
                },
                new Product
                {
                    ProductId = 13,
                    Name = "Ratatouille Cake",
                    Category = "Cake",
                    Price = 22m,
                    Inventory = 10,
                }
            );
        }
    }
}
