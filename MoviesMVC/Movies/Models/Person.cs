using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surnamne { get; set; }

        public List<PersonMoviesRoles> PersonMoviesRoles { get; set; }


    }
}
