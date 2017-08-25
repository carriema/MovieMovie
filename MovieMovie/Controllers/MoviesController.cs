using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieMovie.Models;

namespace MovieMovie.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random() {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }

    }
}
