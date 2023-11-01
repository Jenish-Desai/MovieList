using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesList9.Models;

namespace MoviesList9.Controllers
{
    public class MoviesController : Controller
    {
        private MovieContext context { get; set; }

        public MoviesController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult List()
        {
            var movies = context.Movies.Include(m => m.Genre)
            .OrderBy(m => m.Name).ToList();
            return View(movies);
        }


      
    }
}
