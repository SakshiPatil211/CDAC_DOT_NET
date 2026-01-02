using Microsoft.AspNetCore.Mvc;

namespace TagHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
