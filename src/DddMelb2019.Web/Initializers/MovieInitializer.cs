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
            var ironMan = CreateMovie(context, "Iron Man", new DateTime(2008, 05, 02), "https://m.media-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_UX182_CR0,0,182,268_AL_.jpg", "https://www.imdb.com/title/tt0371746/");
            var noCountryForOldMen = CreateMovie(context, "No Country for Old Men", new DateTime(2008, 01, 18), "https://m.media-amazon.com/images/M/MV5BMjA5Njk3MjM4OV5BMl5BanBnXkFtZTcwMTc5MTE1MQ@@._V1_UY268_CR0,0,182,268_AL_.jpg", "https://www.imdb.com/title/tt0477348/");            
            var leon = CreateMovie(context, "Leon", new DateTime(1995, 02, 03), "https://m.media-amazon.com/images/M/MV5BZDAwYTlhMDEtNTg0OS00NDY2LWJjOWItNWY3YTZkM2UxYzUzXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UY268_CR4,0,182,268_AL_.jpg", "https://www.imdb.com/title/tt0110413/");            
            var theDarkKnight = CreateMovie(context, "The Dark Knight", new DateTime(2008, 07, 24), "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg", "https://www.imdb.com/title/tt0468569/");            
            var theDarkKnightRises = CreateMovie(context, "The Dark Knight Rises", new DateTime(2012, 07, 24), "https://m.media-amazon.com/images/M/MV5BMTk4ODQzNDY3Ml5BMl5BanBnXkFtZTcwODA0NTM4Nw@@._V1_UX182_CR0,0,182,268_AL_.jpg", "https://www.imdb.com/title/tt1345836/");            
            var inception = CreateMovie(context, "Inception", new DateTime(2010, 07, 16), "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg", "https://www.imdb.com/title/tt1375666/");            
            var theDeparted = CreateMovie(context, "The Departed", new DateTime(2006, 10, 06), "https://m.media-amazon.com/images/M/MV5BMTI1MTY2OTIxNV5BMl5BanBnXkFtZTYwNjQ4NjY3._V1_UX182_CR0,0,182,268_AL_.jpg", "https://www.imdb.com/title/tt0407887/");
            var theWolfofWallStreet = CreateMovie(context, "The Wolf of Wall Street", new DateTime(2014, 01, 17), "https://m.media-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_UX182_CR0,0,182,268_AL_.jpg", "https://www.imdb.com/title/tt0993846/");

            //add cast members
            var keanuReeves = CreateCastMember(context, "Keanu", "Reeves", "https://m.media-amazon.com/images/M/MV5BNjUxNDcwMTg4Ml5BMl5BanBnXkFtZTcwMjU4NDYyOA@@._V1_UY317_CR15,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000206/");
            var laurenceFishburn = CreateCastMember(context, "Laurence", "Fishburne", "https://m.media-amazon.com/images/M/MV5BMTc0NjczNDc1MV5BMl5BanBnXkFtZTYwMDU0Mjg1._V1_UX214_CR0,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000401/");
            var carrieAnneMoss = CreateCastMember(context, "Carrie-Anne", "Moss", "https://m.media-amazon.com/images/M/MV5BMTYxMjgwNzEwOF5BMl5BanBnXkFtZTcwNTQ0NzI5Ng@@._V1_UY317_CR12,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0005251/");
            var jeffBridges = CreateCastMember(context, "Jeff", "Bridges", "https://m.media-amazon.com/images/M/MV5BNTU1NjM4MDYzMl5BMl5BanBnXkFtZTcwMjIwMjMyMw@@._V1_UY317_CR11,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000313/");
            var johnGoodman = CreateCastMember(context, "John", "Goodman", "https://m.media-amazon.com/images/M/MV5BOTk1MzAzMDUxMF5BMl5BanBnXkFtZTgwODgyMTQxNjM@._V1_UY317_CR12,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000422/");
            var julianneMoore = CreateCastMember(context, "Julianne", "Moore", "https://m.media-amazon.com/images/M/MV5BMTM5NDI1MjE2Ml5BMl5BanBnXkFtZTgwNDE0Nzk0MDE@._V1_UY317_CR7,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000194/");
            var steveBuscemi = CreateCastMember(context, "Steve", "Buscemi", "https://m.media-amazon.com/images/M/MV5BODc0NTU3NDA4M15BMl5BanBnXkFtZTcwNDkxNzQxNA@@._V1_UY317_CR11,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000114/");
            var robertDowneyJnr = CreateCastMember(context, "Robert", "Downey Jr.", "https://m.media-amazon.com/images/M/MV5BNzg1MTUyNDYxOF5BMl5BanBnXkFtZTgwNTQ4MTE2MjE@._V1_UX214_CR0,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000375/");
            var gwynethPaltrow = CreateCastMember(context, "Gwyneth", "Paltrow", "https://m.media-amazon.com/images/M/MV5BNzIxOTQ1NTU1OV5BMl5BanBnXkFtZTcwMTQ4MDY0Nw@@._V1_UX214_CR0,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000569/");
            var terenceHoward = CreateCastMember(context, "Terrence", "Howard", "https://m.media-amazon.com/images/M/MV5BMTk3NTY4NzgyOV5BMl5BanBnXkFtZTcwODEzNTkxNg@@._V1_UY317_CR24,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0005024/");
            var woodyHarrelson = CreateCastMember(context, "Woody", "Harrelson", "https://m.media-amazon.com/images/M/MV5BMTU3NDc2ODc4MF5BMl5BanBnXkFtZTcwODk2MzAyMg@@._V1_UY317_CR1,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000437/");
            var tommyLeeJones = CreateCastMember(context, "Tommy Lee", "Jones", "https://m.media-amazon.com/images/M/MV5BMTkyNjc4MDc0OV5BMl5BanBnXkFtZTcwOTc5OTUwOQ@@._V1_UX214_CR0,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000169/");
            var javierBardem = CreateCastMember(context, "Javier", "Bardem", "https://m.media-amazon.com/images/M/MV5BMTY1NTc4NTYzMF5BMl5BanBnXkFtZTcwNDIwOTY1NA@@._V1_UX214_CR0,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000849/");
            var joshBrolin = CreateCastMember(context, "Josh", "Brolin", "https://m.media-amazon.com/images/M/MV5BMTQ1MzYyMjQ0Nl5BMl5BanBnXkFtZTcwMTA0ODkyMg@@._V1_UX214_CR0,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000982/");
            var jeanReno = CreateCastMember(context, "Jean", "Reno", "https://m.media-amazon.com/images/M/MV5BMTgzNjA1MjY2M15BMl5BanBnXkFtZTYwMjgzOTk0._V1_UX214_CR0,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000606/");
            var garyOldman = CreateCastMember(context, "Gary", "Oldman", "https://m.media-amazon.com/images/M/MV5BMTc3NTM4MzQ5MV5BMl5BanBnXkFtZTcwOTE4MDczNw@@._V1_UY317_CR0,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000198/");
            var nataliePortman = CreateCastMember(context, "Natalie", "Portman", "https://m.media-amazon.com/images/M/MV5BMTQ3ODE3Mjg1NV5BMl5BanBnXkFtZTcwNzA4ODcxNA@@._V1_UY317_CR11,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000204/");
            var christianBale = CreateCastMember(context, "Christian", "Bale", "https://m.media-amazon.com/images/M/MV5BMTkxMzk4MjQ4MF5BMl5BanBnXkFtZTcwMzExODQxOA@@._V1_UX214_CR0,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000288/");
            var michaelCaine = CreateCastMember(context, "Michael", "Caine", "https://m.media-amazon.com/images/M/MV5BMjAwNzIwNTQ4Ml5BMl5BanBnXkFtZTYwMzE1MTUz._V1_UY317_CR7,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000323/");
            var tomHardy = CreateCastMember(context, "Tom", "Hardy", "https://m.media-amazon.com/images/M/MV5BMTQ3ODEyNjA4Nl5BMl5BanBnXkFtZTgwMTE4ODMyMjE@._V1_UX214_CR0,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0362766/");
            var leonardoDiCaprio = CreateCastMember(context, "Leonardo", "DiCaprio", "https://m.media-amazon.com/images/M/MV5BMjI0MTg3MzI0M15BMl5BanBnXkFtZTcwMzQyODU2Mw@@._V1_UY317_CR10,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000138/");
            var josephGordonLevitt = CreateCastMember(context, "Joseph", "Gordon-Levitt", "https://m.media-amazon.com/images/M/MV5BZTk5ZGQ0OGQtYWYwMy00ZTE1LWE0NWUtMTQ2MmYxMWUxZWM3XkEyXkFqcGdeQXVyMjAyNzk2Nw@@._V1_UY317_CR6,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0330687/");
            var mattDamon = CreateCastMember(context, "Matt", "Damon", "https://m.media-amazon.com/images/M/MV5BMTM0NzYzNDgxMl5BMl5BanBnXkFtZTcwMDg2MTMyMw@@._V1_UY317_CR11,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000354/");
            var jackNicholson = CreateCastMember(context, "Jack", "Nicholson", "https://m.media-amazon.com/images/M/MV5BMTQ3OTY0ODk0M15BMl5BanBnXkFtZTYwNzE4Njc4._V1_UY317_CR7,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000197/");
            var markWahlberg = CreateCastMember(context, "Mark", "Wahlberg", "https://m.media-amazon.com/images/M/MV5BMTU0MTQ4OTMyMV5BMl5BanBnXkFtZTcwMTQxOTY1NA@@._V1_UY317_CR14,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000242/");
            var jonahHill = CreateCastMember(context, "Jonah", "Hill", "https://m.media-amazon.com/images/M/MV5BMTUyNDU0NzAwNl5BMl5BanBnXkFtZTcwMzQxMzIzNw@@._V1_UY317_CR28,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm1706767/");
            var matthewMcConaughey = CreateCastMember(context, "Matthew", "McConaughey", "https://m.media-amazon.com/images/M/MV5BMTg0MDc3ODUwOV5BMl5BanBnXkFtZTcwMTk2NjY4Nw@@._V1_UX214_CR0,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm0000190/");
            var margotRobbie = CreateCastMember(context, "Margot ", "Robbie", "https://m.media-amazon.com/images/M/MV5BMTgxNDcwMzU2Nl5BMl5BanBnXkFtZTcwNDc4NzkzOQ@@._V1_UY317_CR12,0,214,317_AL_.jpg", "https://www.imdb.com/name/nm3053338/");

            //assign cast members to movies
            AssignCastMembersToMovie(context, matrix, keanuReeves, laurenceFishburn, carrieAnneMoss);
            AssignCastMembersToMovie(context, bigLebowski, jeffBridges, johnGoodman, julianneMoore, steveBuscemi);
            AssignCastMembersToMovie(context, ironMan, robertDowneyJnr, gwynethPaltrow, terenceHoward, jeffBridges);
            AssignCastMembersToMovie(context, noCountryForOldMen, tommyLeeJones, javierBardem, joshBrolin, woodyHarrelson);
            AssignCastMembersToMovie(context, leon, jeanReno, garyOldman, nataliePortman);
            AssignCastMembersToMovie(context, theDarkKnight, garyOldman, christianBale, michaelCaine);
            AssignCastMembersToMovie(context, theDarkKnightRises, garyOldman, christianBale, michaelCaine, tomHardy);
            AssignCastMembersToMovie(context, inception, tomHardy, josephGordonLevitt, leonardoDiCaprio);
            AssignCastMembersToMovie(context, theDeparted, mattDamon, jackNicholson, leonardoDiCaprio, markWahlberg);
            AssignCastMembersToMovie(context, theWolfofWallStreet, jonahHill, matthewMcConaughey, leonardoDiCaprio, margotRobbie);

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