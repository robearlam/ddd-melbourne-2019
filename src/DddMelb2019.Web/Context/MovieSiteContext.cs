using Microsoft.EntityFrameworkCore;
using DddMelb2019.Web.Models;

namespace DddMelb2019.Web.Context
{
    public class MovieSiteContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CastMember> CastMembers { get; set; }
        public DbSet<MovieCastMember> MovieCastMembers { get; set;}
        
        public MovieSiteContext(DbContextOptions<MovieSiteContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)    
        {                                                 
            modelBuilder.Entity<MovieCastMember>().HasKey(x => new {x.MovieId, x.CastMemberId});
        }  
    }
}