using System.ComponentModel.DataAnnotations;

namespace final.Models
{
    public class Shipping
    {
        [Key]
        public int ShippingId { get; set; }  // Primary Key

        [Required]
        public int OrderId { get; set; }  // FK to Order
        public Order? Order { get; set; }  // Navigation property

        // Shipping status
        public bool Dispatched { get; set; } = false;
        public bool InTransit { get; set; } = false;
        public bool Delivered { get; set; } = false;

        // Shipping address (can be same as Order address)
        [Required]
        [MaxLength(50)]
        public string? Province { get; set; }

        [Required]
        [MaxLength(50)]
        public string? City { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Street { get; set; }

        [MaxLength(10)]
        public string? Unit { get; set; }

        [Required]
        [MaxLength(10)]
        public string? PostalCode { get; set; }

    }

}
