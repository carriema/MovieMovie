using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieMovie.Models;
using MovieMovie.ViewModels;

namespace MovieMovie.Controllers
{
    [RoutePrefix("Movies")]
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        [Route("Random")]
        public ActionResult Random() {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }

        [Route("Edit/{id}")]
        public ActionResult Edit(int id)
        {
            return Content("id = "+id);
        }

        [Route("Detail/{id}")]
        public ActionResult Detail(int id)
        {
            var movie = _context.movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        [Route("")]
        public ActionResult Index()
        {
            var movies = _context.movies.ToList();
            var movieListView = new MoviesListModel()
            {
                Movies = movies
            };
            return View(movieListView);
        }
    }
}
