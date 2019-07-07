using System.Collections.Generic;
using System.Linq;
using DddMelb2019.Web.Context;
using DddMelb2019.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DddMelb2019.Web.Pages
{
    public class CastMemberModel : PageModel
    {
        private readonly MovieSiteContext movieSiteContext;
        public List<Movie> Movies { get; set; }
        public CastMember CastMember { get; set; }


        public CastMemberModel(MovieSiteContext movieSiteContext)
        {
            this.movieSiteContext = movieSiteContext;
        }

        public IActionResult OnGet(int castMemberId)
        {
            CastMember = movieSiteContext.CastMembers.Where(x => x.CastMemberId == castMemberId).FirstOrDefault();
            if(CastMember == null)
                return Redirect("/");

            Movies = movieSiteContext.MovieCastMembers.Where(x => x.CastMemberId == castMemberId).Select(x => x.Movie).ToList();
            return Page();
        }
    }
}