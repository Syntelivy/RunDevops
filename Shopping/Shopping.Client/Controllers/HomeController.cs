using Microsoft.AspNetCore.Mvc;
using Shopping.Client.Data;

namespace Shopping.Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(ProductContext.Products);
        }
    }
}
