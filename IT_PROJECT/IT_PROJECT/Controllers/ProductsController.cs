using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using IT_PROJECT.Models;

namespace IT_PROJECT.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Products
        public ActionResult Index()
        {
            ViewBag.CategoriesList = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Alphabetical: A-Z", Value = "0" },
                new SelectListItem { Text = "Alphabetical: Z-A", Value = "1" },
                new SelectListItem { Text = "Price: Lowest to Highest", Value = "2" },
                new SelectListItem { Text = "Price: Highest to Lowest", Value = "3" }
            };

            return View("BrowseProducts");
        }

        public async Task<ActionResult> ProductsPartial(int? orderBy, string category = "All", int page = 1, string searchBar = "")
        {
            var productsQuery = db.Products.AsQueryable();
            ProductsPartialViewModel model = new ProductsPartialViewModel();

            if (!category.Equals("All"))
            {
                productsQuery = productsQuery.Where(p => p.Category.Equals(category));
            }

            if(searchBar.Length > 0)
            {
                productsQuery = productsQuery.Where(p => p.Name.ToLower().Contains(searchBar.ToLower()));
            }
            
            switch (orderBy)
            {
                case 1:
                    productsQuery = productsQuery.OrderByDescending(p => p.Name);
                    break;
                case 2:
                    productsQuery = productsQuery.OrderBy(p => p.Price);
                    break;
                case 3:
                    productsQuery = productsQuery.OrderByDescending(p => p.Price);
                    break;
                default:
                    productsQuery = productsQuery.OrderBy(p => p.Name); 
                    break;
            }

            int totalItems = await productsQuery.CountAsync();
            int totalPages = (int)Math.Ceiling(totalItems / (double)model.pageSize);

            var products = await productsQuery.Skip((page - 1) * model.pageSize).Take(model.pageSize).ToListAsync();

            model.products = products;
            model.totalPages = totalPages;
            model.pageNumber = page;
            model.totalItems = totalItems;

            return PartialView("_ProductCards", model);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
