using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProductStore.Models
{
    public class ProductInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            context.Products.Add(new Product { Name = "Tomato soup", Category = "Groceries", Price = 1.39M });
            context.Products.Add(new Product { Name = "Yo-yo", Category = "Toys", Price = 3.75M });
            context.Products.Add(new Product { Name = "Hammer", Category = "Hardware", Price = 16.99M });
        }
    }
}