using Microsoft.AspNetCore.Mvc;
using shopapp.Data;
using shopapp.Models;
using System.Collections.Generic;

namespace shopapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
     
            var viewModel = new ProductViewModel
            {
               
                Products = ProductRepository.Products
            };

            return View(viewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}
