using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Film başlığı eklemelisiniz.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Film başlığı 5-50 karakter arasında olmalıdır.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Film açıklaması eklemelisiniz.")]
        public string Description { get; set; }
        public string Director { get; set; }
        public string[] Players { get; set; }
        [Required(ErrorMessage = "Film Resmi eklemelisiniz.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Film Türü seçmelisiniz.")]
        public int? GenreId { get; set; }
    }
}
