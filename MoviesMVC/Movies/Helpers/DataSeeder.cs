using Microsoft.EntityFrameworkCore;
using Movies.Database;
using Movies.Models;

namespace Movies.Helpers
{
    public static class DataSeeder {


        public static void Initialize(IServiceProvider serviceProvider) {


            using (var context = new MoviesDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MoviesDbContext>>()))
            {

                if (context.people.Any()) {
                    return;
                    //database is seeded
                }

                context.genres.AddRange(
                    
                   new Genre { name = "Action"},
                   new Genre { name = "Comedy" },
                   new Genre { name = "Adventure" },
                   new Genre { name = "Thriller" },
                   new Genre { name = "Sci-Fi" }
                );

                context.roles.AddRange(
                new Role { Name = "Actor" },
                new Role { Name = "Director" },
                new Role { Name = "Producer" }
                );


                context.people.AddRange(
                    //person1, person2
                    new Person { Name = "Tom", Surnamne = "Cruise"},
                    new Person { Name = "Johnny", Surnamne = "Depp" },
                    new Person { Name = "Leonardo", Surnamne = "DiCaprio" }
                    );

                context.SaveChanges();


                
                /*var adv = context.genres.FirstOrDefault(z => z.name == "Adventure");
                var com = context.genres.FirstOrDefault(z => z.name == "Comedy");

                var role1 = context.roles.FirstOrDefault(z => z.Id == 1);

                var role2 = context.roles.FirstOrDefault(z => z.Id == 2);


                var movie1 = new Movie("Pirates of the carribean", 6.9f, 2022, "211", "A movie about pirates",
                    "https://m.media-amazon.com/images/M/MV5BMjE5MjkwODI3Nl5BMl5BanBnXkFtZTcwNjcwMDk4NA@@._V1_.jpg");

                context.movies.AddRange(

                    movie1

                
                ) ;


                context.MovieGenres.Add(new MovieGenres { movieId = 1, genreId = 1 });
                context.MovieGenres.Add(new MovieGenres { movieId = 1, genreId = 2 });
                context.MovieGenres.Add(new MovieGenres { movieId = 1, genreId = 3 });*/



               // context.SaveChanges();


            };
        }
        
    }

}