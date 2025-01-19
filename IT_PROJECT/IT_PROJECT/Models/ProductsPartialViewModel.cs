using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_PROJECT.Models
{
    public class ProductsPartialViewModel
    {
        public IEnumerable<Product> products { get; set; }
        public int pageSize { get; set; }
        public int totalPages { get; set; }
        public int productQuantity { get; set; }
        public int pageNumber { get; set; }
        public int totalItems { get; set; }

        public ProductsPartialViewModel()
        {
            products = new List<Product>();
            pageSize = 9;
            productQuantity = 0;
            pageNumber = 1;
        }
    }
}