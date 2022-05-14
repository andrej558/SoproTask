using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
    public class Movie
    {
        /*public Movie(string title, float rating, int year, string duration, string description, string imageURL)
        {
            Title = title;
            this.rating = rating;
            Year = year;
            Duration = duration;
            Description = description;
            this.imageURL = imageURL;
            //Genres = genres;
            //People = people;
        }
*/
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public float rating { get; set; }

        public int Year { get; set; }

        public int Duration { get; set; }

        public string Description { get; set; }

        public string imageURL { get; set; }


        public string imdbLink { get; set; }

        public List<MovieGenres> MovieGenres { get; set; }

        public List<PersonMoviesRoles> PersonMoviesRoles { get; set; }


    }
}
