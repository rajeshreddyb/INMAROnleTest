using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INMAR_OnlineTest_WebApi.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public static List<Product> GetProducts()
        {

            return new List<Product>()
            {
                new Product { ProductName = "P1", Price = 1000, Description = "P1 Desc" }
        }
    }
}