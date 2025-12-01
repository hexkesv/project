using Microsoft.AspNetCore.Mvc;

namespace final.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Only navbar, no products
            return View();
        }
    }
}
