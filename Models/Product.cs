using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace final.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Category { get; set; } = string.Empty;

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Inventory { get; set; }

        // Stores something like "/images/products/shirt1.jpg"
        [MaxLength(255)]
        public string? ImagePath { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
