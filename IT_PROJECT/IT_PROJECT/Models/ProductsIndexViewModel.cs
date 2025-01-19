using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT_PROJECT.Models
{
    public class ProductsIndexViewModel
    {
        public IEnumerable<SelectListItem> orderByList { get; set; }

        public ProductsIndexViewModel()
        {
            orderByList = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Alphabetical: A-Z", Value = "0" },
                new SelectListItem { Text = "Alphabetical: Z-A", Value = "1" },
                new SelectListItem { Text = "Price: lowest to highest", Value = "2" },
                new SelectListItem { Text = "Price: highest to lowest", Value = "3" }
            };
        }
    }
}