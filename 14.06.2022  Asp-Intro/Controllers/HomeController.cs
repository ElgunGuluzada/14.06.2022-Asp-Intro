using Microsoft.AspNetCore.Mvc;

namespace _14._06._2022__Asp_Intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
