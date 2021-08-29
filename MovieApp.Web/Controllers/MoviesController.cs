using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var filmListesi = new List<Movie>()
            {
                new Movie {Title = "film 1", Description ="açıklama 1", Director = "yonetmen 1", Players=new string[]{"oyuncu 1", "oyuncu 2" }, ImageUrl="1.jpg"},
                new Movie {Title = "film 2", Description ="açıklama 2", Director = "yonetmen 2", Players=new string[]{"oyuncu 3", "oyuncu 4" },ImageUrl="2.jpg"},
                new Movie {Title = "film 2", Description ="açıklama 2", Director = "yonetmen 2", Players=new string[]{"oyuncu 5", "oyuncu 6" },ImageUrl="3.jpg"}

            };
      
            var model = new MovieGenreViewModel()
            {
                Movies = filmListesi
            };
            return View("Movies",model);
        }
        public string Details()
        {
            return "Film Detayı";
        }


    }
}
