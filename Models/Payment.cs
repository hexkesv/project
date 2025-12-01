using System.ComponentModel.DataAnnotations;

namespace final.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }  // Primary Key

        [Required]
        public int OrderId { get; set; }  // FK to Order
        public Order? Order { get; set; }  // Navigation property

        [Required]
        [MaxLength(100)]
        public string? CardHolderName { get; set; }  // Card holder name

        [Required]
        [CreditCard(ErrorMessage = "Invalid credit card number.")]
        public string? CardNumber { get; set; }  // Card number

        [Required]
        [MaxLength(5)]
        public string? ExpiryDate { get; set; }  // MM/YY or MM/YYYY

        [Required]
        [MaxLength(4)]
        public int? CVV { get; set; }  // CVV code

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }  // Amount paid
    }
}
