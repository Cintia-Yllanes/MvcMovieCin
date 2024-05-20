using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class DetalleController : Controller
    {

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            var listMovies = new List<Movie2>();

            var movie1 = new Movie2
            {
                Genre = "Terror",
                Id = 1,
                Price = 1,
                ReleaseDate = DateTime.Now,
                Title = "La noche del terror"
            };
            listMovies.Add(movie1);

            var movie2 = new Movie2
            {
                Genre = "Terror",
                Id = 1,
                Price = 1,
                ReleaseDate = DateTime.Now,
                Title = "La noche del terror II"
            };
            listMovies.Add(movie2);

            return View(listMovies);

        }
        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Simulación de creación de un objeto (model)
            //Mas adelante vamos a ver como usar una base de datos
            var movie = new Movie2
            {
                Genre = "Terror",
                Id = 1,
                Price = 1,
                ReleaseDate = DateTime.Now,
                Title = "La noche del terror"
            };


            return View(movie);
        }
    }
}
