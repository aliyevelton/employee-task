using Microsoft.AspNetCore.Mvc;

namespace NetTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
