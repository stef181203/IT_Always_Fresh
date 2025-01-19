using IT_PROJECT.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT_PROJECT.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = userManager.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            if (user == null)
            {
                return HttpNotFound();
            }
            
            var model = new ShoppingCartViewModel()
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal(),
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult AddToCart(int id, int quantity)
        {
            var product = db.Products.Find(id);

            if (product == null)
                return HttpNotFound();

            var cart = ShoppingCart.GetCart(this.HttpContext);

            cart.AddToCart(product, quantity);

            db.Entry(product).State = EntityState.Modified; 
            db.SaveChanges();

            return RedirectToAction("Index", "Products");
        }

        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            var product = db.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return Json(HttpNotFound());

            cart.RemoveFromCart(id);

            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index", "ShoppingCart");
        }

        public ActionResult Checkout()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            CheckoutViewModel model = new CheckoutViewModel();

            model.TotalAmount = cart.GetTotal();

            return View(model);
        }

        public ActionResult CheckoutConfirmed(CheckoutViewModel model) {
            if(model.TotalAmount == 0)
            {
                return RedirectToAction("Index", "Products");
            }

            if (!ModelState.IsValid)
            {
                return View("Checkout", model);
            }

            var cart = ShoppingCart.GetCart(this.HttpContext);
            cart.EmptyCart();

            return View();
        }
    }
}