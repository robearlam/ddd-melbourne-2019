using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DddMelb2019.Web.Context;
using DddMelb2019.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DddMelb2019.Web.Pages
{
    public class MovieModel : PageModel
    {
        private readonly MovieSiteContext movieSiteContext;
        public Movie Movie { get; set; }
        public List<CastMember> Cast { get; set; }

        public MovieModel(MovieSiteContext movieSiteContext)
        {
            this.movieSiteContext = movieSiteContext;
        }

        public IActionResult OnGet(int movieId)
        {
            Movie = movieSiteContext.Movies.Where(x => x.MovieId == movieId).FirstOrDefault();
            if(Movie == null)
                return Redirect("/");

            Cast = movieSiteContext.MovieCastMembers.Where(x => x.MovieId == movieId).Select(x => x.CastMember).ToList();
            return Page();
        }
    }
}