using Microsoft.AspNetCore.Mvc;

namespace Lesson3.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
