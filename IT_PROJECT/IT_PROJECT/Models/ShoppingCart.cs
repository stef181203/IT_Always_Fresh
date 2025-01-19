using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT_PROJECT.Models
{
    public class ShoppingCart
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private string ShoppingCartId { get; set; }

        public static ShoppingCart GetCart(HttpContextBase context)
        {
            return new ShoppingCart()
            {
                ShoppingCartId = context.User.Identity.Name
            };
        }

        public static ShoppingCart GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }

        public void AddToCart(Product product, int quantity)
        {
            var cartItem = db.CartItems.FirstOrDefault(c => c.CartId == ShoppingCartId && c.ProductId == product.Id);

            if (cartItem == null)
            {
                cartItem = new CartItem()
                {
                    CartId = ShoppingCartId,
                    ProductId = product.Id,
                    Quantity = quantity,
                    TotalPrice = product.Price * quantity
                };

                db.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity += quantity;
                cartItem.TotalPrice += product.Price * quantity;
            }

            db.SaveChanges();
        }

        public void RemoveFromCart(int id)
        {
            var cartItem = db.CartItems.FirstOrDefault(c => c.CartId == ShoppingCartId && c.ProductId == id);

            if (cartItem != null)
            {
                if (cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                    cartItem.TotalPrice -= cartItem.Product.Price;
                }
                else
                {
                    db.CartItems.Remove(cartItem);
                }
                
                db.SaveChanges();
            }
        }

        public void EmptyCart()
        {
            var cartItems = db.CartItems.Where(c => c.CartId == ShoppingCartId);

            foreach (var cartItem in cartItems)
                db.CartItems.Remove(cartItem);

            db.SaveChanges();
        }

        public List<CartItem> GetCartItems()
        {
            return db.CartItems.Where(c => c.CartId == ShoppingCartId).ToList();
        }

        public int GetCount()
        {
            int? count = GetCartItems().Count;

            return count ?? 0;
        }

        public decimal GetTotal()
        {
            decimal? total = GetCartItems().Sum(x => x.TotalPrice);

            return total ?? decimal.Zero;
        }
    }
}