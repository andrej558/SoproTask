using Microsoft.EntityFrameworkCore;
using Movies.Models;

namespace Movies.Database
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Movie> movies { get; set; }


        public DbSet<Genre> genres { get; set; }

        public DbSet<Person> people { get; set; }

        public DbSet<Role> roles { get; set; }


        public DbSet<MovieGenres> MovieGenres { get; set; }

        public DbSet<PersonMoviesRoles> PersonMoviesRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            //MOVIE-GENRES

            modelBuilder.Entity<MovieGenres>().HasKey(table => new
            {
                table.movieId,
                table.genreId
            });

            modelBuilder.Entity<MovieGenres>().
                HasOne(m => m.movie)
                .WithMany(p => p.MovieGenres)
                .HasForeignKey(m => m.movieId);

            modelBuilder.Entity<MovieGenres>().
                HasOne(m => m.genre)
                .WithMany(p => p.MovieGenres)
                .HasForeignKey(m => m.genreId);


            //MOVIE-PERSON-ROLE

            modelBuilder.Entity<PersonMoviesRoles>().HasKey(table => new
            {
                table.PersonId,
                table.RoleId,
                table.MovieId
            });

            modelBuilder.Entity<PersonMoviesRoles>()
                .HasOne(p => p.Person)
                .WithMany(pr => pr.PersonMoviesRoles)
                .HasForeignKey(p => p.PersonId);
            modelBuilder.Entity<PersonMoviesRoles>()
                .HasOne(r => r.Role)
                .WithMany(pr => pr.PersonMoviesRoles)
                .HasForeignKey(r => r.RoleId);
            modelBuilder.Entity<PersonMoviesRoles>()
                .HasOne(m => m.Movie)
                .WithMany(pr => pr.PersonMoviesRoles)
                .HasForeignKey(m => m.MovieId);



            base.OnModelCreating(modelBuilder);
        }
    }
}
