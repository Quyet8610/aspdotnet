using Microsoft.AspNetCore.Mvc;

namespace aspdotnet.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.BeSang = "hhhh";
            return View();
        }
    }
}