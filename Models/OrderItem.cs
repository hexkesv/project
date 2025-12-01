using System.ComponentModel.DataAnnotations;

namespace final.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        [Required]
        public int OrderId { get; set; }
        public Order? Order { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }  // Price at time of purchase
    }
}
