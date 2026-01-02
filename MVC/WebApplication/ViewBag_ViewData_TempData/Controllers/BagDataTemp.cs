using Microsoft.AspNetCore.Mvc;
using ViewBag_ViewData_TempData.Models;

namespace ViewBag_ViewData_TempData.Controllers
{
    public class BagDataTemp : Controller
    {
        public IActionResult Index()
        {
            ViewBag.msg = "Hello from sakshi";

            Employee e = new Employee() { Id = 1, Name = "Tom", Address = "Pune" };
            ViewBag.emp = e;

            ViewData["number"] = 12345;

            Employee emp1 = new Employee() { Id = 102, Name = "Tom Hanks", Address = "LA" };
            ViewData["emp1"] = emp1;

            TempData["PIN"] = 223344;
            return View();

        }
    }
}
