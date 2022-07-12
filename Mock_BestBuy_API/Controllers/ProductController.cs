using Microsoft.AspNetCore.Mvc;

namespace Mock_BestBuy_API.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
