using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_PROJECT.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Weight {  get; set; }
        public string ImageURL { get; set; }
    }
}