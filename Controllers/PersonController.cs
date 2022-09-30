using Microsoft.AspNetCore.Mvc;

namespace aspdotnet.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string names)
        {
            ViewBag.abc = names;
            return View();
        }
        
        public IActionResult ABC()
        {
            return View();
        }
    }

}