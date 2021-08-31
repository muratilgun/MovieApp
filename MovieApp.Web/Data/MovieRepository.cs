using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie> _movies = null;
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie 
                {
                    MovieId = 1,
                    Title = "film 1", 
                    Description ="açıklama 1", 
                    Director = "yonetmen 1", 
                    Players=new string[]{"oyuncu 1", "oyuncu 2" }, 
                    ImageUrl="1.jpg",
                    GenreId = 1
                },
                new Movie 
                {
                    MovieId = 2,
                    Title = "film 2", 
                    Description ="açıklama 2",
                    Director = "yonetmen 2", 
                    Players=new string[]{"oyuncu 3", "oyuncu 4" },
                    ImageUrl="2.jpg",
                    GenreId = 1

                },
                new Movie
                {
                    MovieId = 3,
                    Title = "film 3", 
                    Description ="açıklama 3", 
                    Director = "yonetmen 3", 
                    Players=new string[]{"oyuncu 5", "oyuncu 6" },
                    ImageUrl="3.jpg",
                    GenreId = 3
                },    new Movie
                {
                    MovieId = 4,
                    Title = "film 4",
                    Description ="açıklama 4",
                    Director = "yonetmen 4",
                    Players=new string[]{"oyuncu 7", "oyuncu 8" },
                    ImageUrl="1.jpg",
                    GenreId = 3
                },
                new Movie
                {
                    MovieId = 5,
                    Title = "film 5",
                    Description ="açıklama 5",
                    Director = "yonetmen 5",
                    Players=new string[]{"oyuncu 9", "oyuncu 10" },
                    ImageUrl="2.jpg",
                    GenreId = 3
                },
                new Movie
                {
                    MovieId = 6,
                    Title = "film 6",
                    Description ="açıklama 6",
                    Director = "yonetmen 6",
                    Players=new string[]{"oyuncu 11", "oyuncu 12" },
                    ImageUrl="3.jpg",
                    GenreId = 4
                }
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void Add(Movie movie) 
        {
            _movies.Add(movie);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(m => m.MovieId == id);
        }
    }
}
