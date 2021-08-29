using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string filmBasligi = "Film Başlığı";
            string filmAciklama = "Filmin Açıklaması";
            string filmYonetmeni = "Filmin yönetmen adı";
            string[] oyuncular = { "oyuncu 1", "oyuncu 2" };

            var m = new Movie();
            m.Title = filmBasligi;
            m.Description = filmAciklama;
            m.Director = filmYonetmeni;
            m.Players = oyuncular;
            m.ImageUrl = "1.jpg";

            return View(m);

        }
        public IActionResult About()
        {
            return View();
        }
    }
}
