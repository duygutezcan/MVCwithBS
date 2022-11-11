using Microsoft.AspNetCore.Mvc;

namespace MVCwithBS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
          public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
