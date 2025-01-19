using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_PROJECT.Models
{
    public class CheckoutViewModel
    {
        [Required]
        [Display(Name="Shipping address")]
        public string Address { get; set; }
        [RegularExpression("^07\\d\\s?\\d{3}\\s?\\d{3}$", ErrorMessage="The phone number format is invalid!")]
        [Display(Name="Phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name= "Full Name")]
        public string FullName { get; set; }
        [RegularExpression("^\\d{4}\\s?\\d{4}\\s?\\d{4}\\s?\\d{4}$", ErrorMessage="The card number is invalid!")]
        [Display(Name = "Card number")]
        public string CardNumber { get; set; }
        [Range(100, 999, ErrorMessage="CVV input is invalid!")]
        [Required]
        public int CVV { get; set; }
        [Required]
        public int ExpiryMonth { get; set; }
        [Required]
        public int ExpiryYear { get; set; }
        [Display(Name="Total amount")]
        public decimal TotalAmount { get; set; }
    }
}