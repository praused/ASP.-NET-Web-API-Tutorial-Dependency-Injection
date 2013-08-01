﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ProductStore.Models
{
    public class ProductRepository : IProductRepository
    {
        private ProductContext db = new ProductContext();

        public ProductRepository()
        {
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public Product Add(Product item)
        {
            db.Products.Add(item);
            db.SaveChanges();
            return item;
        }

        public void Remove(int id)
        {
            Product product = db.Products.Find(id); 
            db.Products.Remove(product); 
            db.SaveChanges(); 
        }

        public bool Update(Product item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
    }
}