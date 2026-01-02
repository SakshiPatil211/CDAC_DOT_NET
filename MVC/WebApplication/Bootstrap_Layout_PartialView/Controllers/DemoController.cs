using Bootstrap_Layout_PartialView.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap_Layout_PartialView.Controllers
{
    public class DemoController : Controller
    {
        private Product _product1 = new Product()
        {
            Id =1,
            Name = "Asus LAptop",
            Price = 50000
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetProducts()
        {
            ProductViewModel pvm = new ProductViewModel()
            {
                product = _product1,
                CategoryName = "Electronics",
                isInStock = true,
                Message = "This is a high-performance laptop suitable for gaming and professional work. OFFER: 50% discount"
            };

            return View(pvm);
        }
    }
}
