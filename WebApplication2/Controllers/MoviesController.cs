using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Random()
        {
            var movie = new Movies() { Id = 1,Title="Avengers" };
            return View(movie);
        }
    }
}
