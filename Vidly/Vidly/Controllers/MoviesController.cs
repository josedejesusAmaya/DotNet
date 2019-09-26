using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Harry Potter and the deathly hallows" },
                new Movie { Id = 2, Name = "The Pursuit of happiness"}
            };
        }

        /*public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer() { Name = "Pepe Amaya"},
                new Customer() { Name = "Emiliano Amaya"}
            };

            var viewModel = new RandomMovieViewModel
            {
                movie = movie,
                customers = customers
            };
            return View(viewModel);

            //ViewData["Movie"] = movie;
            //return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page=1, sortBy="name"});
        }*/

        /*public ActionResult Edit(int id)
        {
            return Content("id" + id);
        }*/

        /*
         * Movies
         */
         /*public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }*/

        /*[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Customers()
        {

            return View();
        }*/
    }
}