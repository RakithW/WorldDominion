using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}