using Microsoft.AspNetCore.Mvc;

namespace aspdotnet.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string name)
        {
            ViewBag.ab = name;
            return View();
        }
    }
}