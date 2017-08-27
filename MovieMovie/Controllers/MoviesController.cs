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
            if (id == 1)
            {
                return View(new Movie() { Id = 1, Name = "Your Name" });
            } else if (id==2)
            {
                return View(new Movie() { Id = 2, Name = "Comeback Home" });
            } else
            {
                return HttpNotFound();
            }
        }

        [Route("")]
        public ActionResult Index()
        {
            var movies = new List<Movie>()
            {
                new Movie() {Id = 1, Name = "Your Name"},
                new Movie() {Id = 2, Name="Comeback Home"}
            };
            var movieListView = new MoviesListModel()
            {
                Movies = movies
            };
            return View(movieListView);
        }
    }
}
