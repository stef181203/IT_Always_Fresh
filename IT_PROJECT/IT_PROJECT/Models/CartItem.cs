using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_PROJECT.Models
{
    public class CartItem
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string CartId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual Product Product { get; set; }
    }
}