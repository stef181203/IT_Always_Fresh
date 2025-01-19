using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_PROJECT.Models
{
    public class ShoppingCartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal CartTotal { get; set; }
        public int TotalQuantity { get; set; }

        public void updateTotalQuantity()
        {
            var quantity = 0;
            foreach (var item in CartItems)
            {
                quantity += item.Quantity;
            }

            TotalQuantity = quantity;
        }
    }
}