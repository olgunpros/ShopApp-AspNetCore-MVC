using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using shopapp.Data;
using shopapp.Models;

namespace shopapp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new Product { Name = "Iphone X", Price = 6000, Description = "güzel telefon" };

            // ViewData["Category"] = "Telefonlar";
            // ViewData["Product"] = product;

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;

            // ViewBag.Product
            return View(product);
        }

        public IActionResult list(int? id, string q)
        {
            var products = ProductRepository.Products;

           
            if (id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }
           if (!string.IsNullOrEmpty(q)) 
{
    products = products.Where(i => i.Name.Contains(q) || i.Description.Contains(q) ).ToList();
}


            var productViewModel = new ProductViewModel()
            {
                Products = products 
            };

            return View(productViewModel);
        }

        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }
       public IActionResult Create()
{
    ViewBag.Categories = CategoryRepository.Categories;
    return View(new Product());
}


        [HttpPost]
         public IActionResult Create(Product p) {
            if(ModelState.IsValid) {
            ProductRepository.AddProduct(p);

            return RedirectToAction("list");

            }
            ViewBag.Categories = CategoryRepository.Categories;
            return View(p);

           
        }
        [HttpGet]
        public IActionResult Edit(int id) {
            ViewBag.Categories = CategoryRepository.Categories;
            return View(ProductRepository.GetProductById(id));
        }
        [HttpPost]
        public IActionResult Edit(Product p) {
            ProductRepository.EditProduct(p);
            return RedirectToAction("list");
        }
        public IActionResult Delete(int ProductId) {
            ProductRepository.DeleteProduct(ProductId);
            return RedirectToAction("list");
        }
    }
}
