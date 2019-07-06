namespace DddMelb2019.Web.Models
{
    public class MovieCastMember
    {
        public int MovieId { get; set; }
        public int CastMemberId { get; set; }
        public Movie Movie { get; set; }
        public CastMember CastMember { get; set; }

        public MovieCastMember(Movie movie, CastMember castMember)
        {
            Movie = movie;
            CastMember = castMember;
        }

        public MovieCastMember() { }
    }
}