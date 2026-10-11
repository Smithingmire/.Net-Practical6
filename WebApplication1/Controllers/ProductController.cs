using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> P = new List<Product>();
            P = GetProducts();
            return View(P);
        }

        //product details view
        public ActionResult Details(int id)
        {
            List<Product> PALL = GetProducts();
            Product P1 = PALL.FirstOrDefault(p => p.ProductId == id);
            return View(P1);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    ProductDescription = "A high-performance laptop for all your computing needs.",
                    ProductPrice = 67990,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Smartphone",
                    ProductDescription = "A sleek and powerful smartphone with the latest features.",
                    ProductPrice = 49990,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Headphones",
                    ProductDescription = "Noise-cancelling headphones for an immersive audio experience.",
                    ProductPrice = 19990,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "Coffee Maker",
                    ProductDescription = "Brew your favorite coffee with ease using this coffee maker.",
                    ProductPrice = 7990,
                    Category = "Home Appliances"
                }

            };
        }
    }
}