using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RazorViewEngine.Models;

namespace RazorViewEngine.Controllers
{
    public class HomeController : Controller
    {
        public List<ProductModel> products = new List<ProductModel>()
        {
            new ProductModel()
            {
                Id = 1,
                Name = "Product 1",
                Available = true,
                Price = 550000,
                PromotionPrice = 50000
            },

            new ProductModel()
            {
                Id = 2,
                Name = "Product 2",
                Available = false,
                Price = 730000,
                PromotionPrice = 20000
            },

            new ProductModel()
            {
                Id = 3,
                Name = "Product 3",
                Available = true,
                Price = 850000,
                PromotionPrice = 30000
            },

            new ProductModel()
            {
                Id = 4,
                Name = "Product 4",
                Available = true,
                Price = 220000,
                PromotionPrice = 10000
            },

            new ProductModel()
            {
                Id = 5,
                Name = "Product 5",
                Available = false,
                Price = 730000,
                PromotionPrice = 20000
            },

            new ProductModel()
            {
                Id = 6,
                Name = "Product 6",
                Available = true,
                Price = 990000,
                PromotionPrice = 10000
            },
        };

        public IActionResult Product()
        { 
            return View(products);
        }
    }
}
