using Microsoft.AspNetCore.Mvc;

namespace Convential_Custom_Routing.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
