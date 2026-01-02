using System.Diagnostics;
using EntityFrameworkWithDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkWithDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IETDBContext _dbcontext;

        public HomeController(IETDBContext _dbcontext)
        {
            this._dbcontext = _dbcontext;
        }

        public IActionResult Index()
        {
            ViewBag.ctr = "Home";
            var allEmps = _dbcontext.emps.ToList();
            return View(allEmps);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
