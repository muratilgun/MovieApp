using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Web.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Data
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MovieContext>();
            context.Database.Migrate();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Movies.Count() == 0)
                {
                    context.Movies.AddRange
                        (
                            new List<Movie>()
                    {
                        new Movie {
                                    MovieId=1,
                                    Title="Jiu Jitsu",
                                    Description="Every six years, an ancient order of jiu-jitsu fighters joins f    o   rces to        battle     a       vicious race of alien invaders. But when a c el  ebrated war    hero goes  down in     defeat, the fate    of   the planet and m       ankind hangs in    the balance.",
                                    Director="Dimitri Logothetis",
                                    //Players=new string[] { "Nicolas Cage", "Alain Moussi"},
                                    ImageUrl="1.jpg",
                                    GenreId=1
                                   },
                        new Movie {
                        MovieId=2,
                        Title="Fatman",
                        Description="A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a neglected and precocious 12 year old, hires a hit m...",
                        Director="Eshom Nelms",
                        //Players=new string[] { "Mel Gibson", "Walton Goggins","Michelle Lan"},
                        ImageUrl="2.jpg",
                        GenreId=1
                    },
                        new Movie {
                                    MovieId=3,
                            Title="The Dalton Gang",
        Description="When their brother Frank is killed by an outlaw, brothers Bob Dalton, Emmett Dalton and Gray Dalton join their local sheriff's department. When the...",
        Director="Christopher Forbes",
        //Players=new string[] { "oyuncu 1","oyuncu 2"},
        ImageUrl="3.jpg",
        GenreId=3
    },
                        new Movie {
                        MovieId=4,
                        Title="Tenet",
                        Description="Armed with only one word - Tenet - and fighting for the survival ofthe   entire        world,      the Protagonist journeys through a twilight worl of    internat...",
                        Director="Christopher Nolan",
                        //Players=new string[] { "Robert Pattinson", "Elizabeth Debicki"},
                        ImageUrl="4.jpg",
                        GenreId=3
    },
                        new Movie {
                            MovieId=5,
                            Title="The Craft: Legacy",
                            Description="An eclectic foursome of aspiring teenage witches get more thanthey       bargained     for     as       they lean into their newfound powers.",
                            Director="Zoe Lister-Jones",
                            //Players=new string[] { "Cailee Spaeny", "Zoey Luna"},
                            ImageUrl="5.jpg",
                            GenreId=3
                        },
                        new Movie {
                            MovieId=6,
                            Title="Hard Kill",
                            Description="The work of billionaire tech CEO Donovan Chalmers is so valuablethat     he  hires                mercenaries to protect it, and a terroristgroup kidnaps    his    daughte...",
                            Director="Matt Eskandari",
                            //Players=new string[] { "Bruce Willis", "Jesse Metcalfe"},
                            ImageUrl="6.jpg",
                            GenreId=4
                        }
                    }
                        );
                }
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange
                        (
                             new List<Genre>
                             {

                                 new Genre{GenreId=1,Name="Macera"},
                                 new Genre{GenreId=2,Name="Komedi"},
                                 new Genre{GenreId=3,Name="Romantik"},
                                 new Genre{GenreId=4,Name="Savaş"},
                                 new Genre{GenreId=5,Name="Bilim Kurgu"}
                             }
                        );
                }
                context.SaveChanges();
            }
        }
    }
}
