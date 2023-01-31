using Microsoft.AspNetCore.Mvc;
using Videly.Models;

namespace Videly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shark", Id=1 };

            return View(movie);
        }
    }
}
