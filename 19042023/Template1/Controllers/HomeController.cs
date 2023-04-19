using Microsoft.AspNetCore.Mvc;

namespace Template1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
