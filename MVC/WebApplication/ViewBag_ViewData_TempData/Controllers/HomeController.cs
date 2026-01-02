using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewBag_ViewData_TempData.Models;

namespace ViewBag_ViewData_TempData.Controllers
{
    //[Route("Home")]
    public class HomeController : Controller
    {

        List<Employee> empList = new List<Employee>()
            {
                new Employee(){ Id= 101, Name= "Pooja", Address="Pune"},
                new Employee(){ Id= 102, Name= "Neha", Address="Nagpur"},
                new Employee(){ Id= 103, Name= "Tina", Address="Thane"},
                new Employee(){ Id= 104, Name= "Pinky", Address="Puri"},
                new Employee(){ Id= 105, Name= "Jaspreet", Address="Jamnagar"},

            };

        List<Customer> customerList = new List<Customer>() {
         new Customer(){CId= 1, CName="Bob", BillNo= 1234 },
         new Customer(){CId= 2, CName="Rob", BillNo= 5678 },
         new Customer(){CId= 3, CName="Tom", BillNo= 2468 },
        };

        public IActionResult Index()
        {
            long phone = 85967545457;
            return View(phone);
        }

        //[Route("Index")]
        public IActionResult GetEmps()
        {
            return View(empList);
        }

        public IActionResult GetRecords()
        {
            ViewModelEmpCut empcus = new ViewModelEmpCut()
            {
                elist = empList,
                clist = customerList
            };

            return View(empcus);
        }






        public IActionResult Privacy()
        {
            return View();
        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
