using Microsoft.AspNetCore.Mvc;
using SadikTuranYoutube.Models;

namespace SadikTuranYoutube.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var course = new Course { Id = 323, Name = "Asp Net Kursu" };
            return View(course);
        }
    }
}