using Lesson3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lesson3.Controllers
{
    public class HomeController : Controller
    {
        List<Slider> sliders = new List<Slider>
        {

        };
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
