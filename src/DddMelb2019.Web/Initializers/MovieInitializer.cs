using DddMelb2019.Web.Models;
using DddMelb2019.Web.Context;
using System;
using System.Linq;

namespace DddMelb2019.Web.Initializers
{
    public class MovieInitializer
    {
        public static void Initialize(MovieSiteContext context)
        {
            context.Database.EnsureCreated();
            
            Movie movie = new Movie() 
            {
                Title = "The Matrix",
                DateOfRelease = new DateTime(1999, 06, 11),
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX182_CR0,0,182,268_AL_.jpg",
                ImdbUrl = "https://www.imdb.com/title/tt0133093/"
            };
            context.Movies.Add(movie);

            var castMember = new CastMember()
            {
                FirstName = "Keanu",
                LastName = "Reeves",
                ImdbUrl = "https://www.imdb.com/name/nm0000206/",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjUxNDcwMTg4Ml5BMl5BanBnXkFtZTcwMjU4NDYyOA@@._V1_UY317_CR15,0,214,317_AL_.jpg"
            };
            context.CastMembers.Add(castMember);
            context.MovieCastMembers.Add(new MovieCastMember(movie, castMember));
            context.SaveChanges();
                  
                //     new CastMember
                //     {
                //         FirstName = "Laurence",
                //         LastName = "Fishburne",
                //         ImdbUrl = "https://www.imdb.com/name/nm0000401/",
                //         ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc0NjczNDc1MV5BMl5BanBnXkFtZTYwMDU0Mjg1._V1_UX214_CR0,0,214,317_AL_.jpg"
                //     },
                //     new CastMember
                //     {
                //         FirstName = "Carrie-Anne",
                //         LastName = "Moss",
                //         ImdbUrl = "https://www.imdb.com/name/nm0005251/",
                //         ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTYxMjgwNzEwOF5BMl5BanBnXkFtZTcwNTQ0NzI5Ng@@._V1_UY317_CR12,0,214,317_AL_.jpg"
                //     }
                // }
        }
    }
}