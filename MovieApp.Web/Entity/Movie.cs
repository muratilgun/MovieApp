using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Web.Entity
{
    public class Movie
    {
        //[Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public int? GenreId { get; set; }
    }
}
