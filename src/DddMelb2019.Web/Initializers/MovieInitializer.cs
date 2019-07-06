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

            //add movies
            var matrix = CreateMovie(context, "The Matrix", new DateTime(1999, 06, 11), "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX182_CR0,0,182,268_AL_.jpg", "https://www.imdb.com/title/tt0133093/");
            var bigLebowski = CreateMovie(context, "The Big Lebowski", new DateTime(1998, 04, 24), "https://m.media-amazon.com/images/M/MV5BMTQ0NjUzMDMyOF5BMl5BanBnXkFtZTgwODA1OTU0MDE@._V1_UX182_CR0,0,182,268_AL_.jpg", "https://www.imdb.com/title/tt0118715/");

            //add cast members
            var keanuReeves = CreateCastMember(context, "Keanu", "Reeves", "https://m.media-amazon.com/images/M/MV5BNjUxNDcwMTg4Ml5BMl5BanBnXkFtZTcwMjU4NDYyOA@@._V1_UY317_CR15,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000206/");
            var laurenceFishburn = CreateCastMember(context, "Laurence", "Fishburne", "https://m.media-amazon.com/images/M/MV5BMTc0NjczNDc1MV5BMl5BanBnXkFtZTYwMDU0Mjg1._V1_UX214_CR0,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000401/");
            var carrieAnneMoss = CreateCastMember(context, "Carrie-Anne", "Moss", "https://m.media-amazon.com/images/M/MV5BMTYxMjgwNzEwOF5BMl5BanBnXkFtZTcwNTQ0NzI5Ng@@._V1_UY317_CR12,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0005251/");
            var jeffBridges = CreateCastMember(context, "Jeff", "Bridges", "https://m.media-amazon.com/images/M/MV5BNTU1NjM4MDYzMl5BMl5BanBnXkFtZTcwMjIwMjMyMw@@._V1_UY317_CR11,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000313/");
            var johnGoodman = CreateCastMember(context, "John", "Goodman", "https://m.media-amazon.com/images/M/MV5BOTk1MzAzMDUxMF5BMl5BanBnXkFtZTgwODgyMTQxNjM@._V1_UY317_CR12,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000422/");
            var julianneMoore = CreateCastMember(context, "Julianne", "Moore", "https://m.media-amazon.com/images/M/MV5BMTM5NDI1MjE2Ml5BMl5BanBnXkFtZTgwNDE0Nzk0MDE@._V1_UY317_CR7,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000194/");
            var steveBuscemi = CreateCastMember(context, "Steve", "Buscemi", "https://m.media-amazon.com/images/M/MV5BODc0NTU3NDA4M15BMl5BanBnXkFtZTcwNDkxNzQxNA@@._V1_UY317_CR11,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000114/");

            //assign cast members to movies
            AssignCastMembersToMovie(context, matrix, keanuReeves, laurenceFishburn, carrieAnneMoss);
            AssignCastMembersToMovie(context, bigLebowski, jeffBridges, johnGoodman, julianneMoore, steveBuscemi);

            //persist changes to data store
            context.SaveChanges();
        }

        private static void AssignCastMembersToMovie(MovieSiteContext context, Movie movie, params CastMember[] castMembers)
        {
            foreach(var castMember in castMembers)
            {
                if(context.MovieCastMembers.Any(x => x.CastMemberId == castMember.CastMemberId && x.MovieId == movie.MovieId))
                    continue;

                context.MovieCastMembers.Add(new MovieCastMember(movie, castMember));
            }
        }

        private static CastMember CreateCastMember(MovieSiteContext context, string firstName, string lastName, string imageUrl, string imdbUrl)
        {
            if(context.CastMembers.Any(x => x.ImdbUrl == imdbUrl))
                return context.CastMembers.First(x => x.ImdbUrl == imdbUrl);

            var castMember = new CastMember()
            {
                FirstName = firstName,
                LastName = lastName,
                ImageUrl = imageUrl,
                ImdbUrl = imdbUrl
            };
            context.CastMembers.Add(castMember);
            return castMember;
        }

        private static Movie CreateMovie(MovieSiteContext context, string title, DateTime dateOfRelease, string imageUrl, string imdbUrl)
        {
            if(context.Movies.Any(x => x.ImdbUrl == imdbUrl))
                return context.Movies.First(x => x.ImdbUrl == imdbUrl);

            Movie movie = new Movie()
            {
                Title = title,
                DateOfRelease = dateOfRelease,
                ImageUrl = imageUrl,
                ImdbUrl = imdbUrl
            };
            context.Movies.Add(movie);
            return movie;
        }
    }
}