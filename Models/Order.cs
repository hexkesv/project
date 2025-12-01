using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace final.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }  // Primary Key

        [Required]
        public int CustomerId { get; set; }  // Foreign Key
        public Customer? Customer { get; set; } // Navigation property

        [Required]
        [Range(0, double.MaxValue)]
        public decimal TotalPrice { get; set; }  // Total amount for the whole order

        [Required]
        [MaxLength(100)]
        public string Street { get; set; } = string.Empty;

        [MaxLength(10)]
        public string? Unit { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; } = string.Empty;

        // ✅ 1 Order -> Many OrderItems
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
