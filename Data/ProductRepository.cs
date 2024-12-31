using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.Models;

namespace shopapp.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product {Name = "Iphone 7", Price = 3000, Description = "Old Phone", IsApproved = false, ImageUrl = "1.jpg"},
                new Product {ProductId = 1, Name = "Iphone 8", Price = 4000, Description = "Best Phone", IsApproved = true, ImageUrl = "1.jpg", CategoryId = 1},
                new Product {ProductId = 2, Name = "Iphone 8+", Price = 5000, Description = "The Cheaper Phone", IsApproved = true, ImageUrl = "2.jpg", CategoryId = 2},
                new Product {ProductId = 3, Name = "Galaxy J7 Prime", Price = 7000, Description = "For Fans", ImageUrl = "3.jpg", CategoryId = 2}
            };
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }

        public static void EditProduct(Product product)
        {
            foreach (var p in _products)
            {
                if (p.ProductId == product.ProductId)
                {
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.ImageUrl = product.ImageUrl;
                    p.Description = product.Description;
                    p.IsApproved = product.IsApproved;
                    p.CategoryId = product.CategoryId;
                }
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
