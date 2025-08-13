using Microsoft.AspNetCore.Mvc;

namespace MVCMovies.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int number)
        {
            ViewData["Title"] = "Welcome";
            ViewData["Name"] = name;
            ViewData["Number"] = number;

            return View();
        }
    }
}
