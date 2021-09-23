using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieApp.Web.Entity;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult List(int? id, string q)
        {
            //var controller = RouteData.Values["controller"];
            //var action = RouteData.Values["action"];
            //var genreid = RouteData.Values["id"];
            //var kelime = HttpContext.Request.Query["q"].ToString();

            //var movies = MovieRepository.Movies;
            var movies = _context.Movies.AsQueryable();
            if (id != null)
            {
                movies = movies.Where(m => m.GenreId == id);
            }

            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i =>
                    i.Title.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q.ToLower()));
            }
            var model = new MoviesViewModel()
            {
                Movies = movies.ToList()
            };
            return View("Movies", model);

        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_context.Movies.Find(id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Movie m)
        {
            if (ModelState.IsValid)
            {
                // MovieRepository.Add(m);

                _context.Movies.Add(m);
                _context.SaveChanges();
                TempData["Message"] = $"{m.Title} isimli film eklendi.";
                return RedirectToAction("List");
            }
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View(_context.Movies.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            if (ModelState.IsValid)
            {
                //MovieRepository.Edit(m);
                _context.Movies.Update(m);
                _context.SaveChanges();
                return RedirectToAction("Details", "Movies", new { @id = m.MovieId });
            }
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View(m);
        }

        [HttpPost]
        public IActionResult Delete(int movieId, string title)
        {
            //MovieRepository.Delete(movieId);
            var movie = _context.Movies.Find(movieId);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            TempData["Message"] = $"{title} isimli film silindi.";
            return RedirectToAction("List");
        }

    }
}
