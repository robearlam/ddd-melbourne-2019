﻿using System.Collections.Generic;
using System.Threading.Tasks;
using DddMelb2019.Web.Context;
using DddMelb2019.Web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DddMelb2019.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MovieSiteContext movieSiteContext;

        public List<Movie> Movies { get; set; }

        public IndexModel(MovieSiteContext movieSiteContext)
        {
            this.movieSiteContext = movieSiteContext;
        }

        public async Task OnGetAsync()
        {
            Movies = await movieSiteContext.Movies.ToListAsync();
        }
    }
}
