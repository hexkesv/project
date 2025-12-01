using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace final.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }  // Primary Key

        [Required(ErrorMessage = "Please enter an email.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your first name.")]
        [MaxLength(50)]
        public string? Fname { get; set; }

        [MaxLength(50)]
        public string? Mname { get; set; }   // Optional middle name

        [Required(ErrorMessage = "Please enter your last name.")]
        [MaxLength(50)]
        public string? Lname { get; set; }

        [Required(ErrorMessage = "Please enter your province.")]
        [MaxLength(50)]
        public string? Province { get; set; }

        [Required(ErrorMessage = "Please enter your city.")]
        [MaxLength(50)]
        public string? City { get; set; }

        [Required(ErrorMessage = "Please enter your street.")]
        [MaxLength(100)]
        public string? Street { get; set; }

        [MaxLength(10)]
        public string? Unit { get; set; }    // Optional apartment/unit

        [Required(ErrorMessage = "Please enter your postal code.")]
        [MaxLength(10)]
        public string? PostalCode { get; set; }

        private ICollection<Order>? orders;

        // Navigation property: Customer's Orders (1-to-many)
        public ICollection<Order>? GetOrders()
        {
            return orders;
        }

        public void SetOrders(ICollection<Order>? value)
        {
            orders = value;
        }
    }
}
