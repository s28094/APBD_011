using Microsoft.AspNetCore.Mvc;
using APBD_11.Models;

namespace APBD_11.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product1", Price = 10.0M },
                new Product { Id = 2, Name = "Product2", Price = 20.0M }
            };
            return View(products);
        }
    }
}