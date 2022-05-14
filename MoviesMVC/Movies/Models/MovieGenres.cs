namespace Movies.Models
{
    public class MovieGenres
    {
        public int movieId { get; set; }
        public Movie movie { get; set; }


        public int genreId { get; set; }
        public Genre genre { get; set; }
    }
}
