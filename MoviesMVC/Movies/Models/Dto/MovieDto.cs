using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models.Dto
{
    public class MovieDto
    {

        public MovieDto() {
            //ActorsIds = new List<int>();
        }

        public string Title { get; set; }

        public float rating { get; set; }

        public int Year { get; set; }

        public int Duration { get; set; }

        public string Description { get; set; }

        public string imageURL { get; set; }


        public string imdbLink { get; set; }


        [Display(Name = "Genres")]
        [Required(ErrorMessage = "Movie Genre is required")]
        public List<int> GenreIds { get; set; }


        [Display(Name = "Actors")]
        [Required(ErrorMessage = "Movie Cast is required")]
        public List<int> ActorsIds { get; set; }

        [Display(Name = "Directors")]
        [Required(ErrorMessage = "Movie Cast is required")]
        public List<int> DirectorsIds { get; set; }

        [Display(Name = "Producers")]
        [Required(ErrorMessage = "Movie Cast is required")]
        public List<int> ProducersIds { get; set; }
    }
}
