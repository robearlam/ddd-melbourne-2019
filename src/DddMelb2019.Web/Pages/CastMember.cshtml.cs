using System.Threading.Tasks;
using DddMelb2019.Web.Context;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DddMelb2019.Web.Pages
{
    public class CastMemberModel : PageModel
    {
        private readonly MovieSiteContext movieSiteContext;

        public CastMemberModel(MovieSiteContext movieSiteContext)
        {
            this.movieSiteContext = movieSiteContext;
        }

        public async Task OnGetAsync()
        {
            
        }
    }
}