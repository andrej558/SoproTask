using AutoMapper;
using Movies.Models;
using Movies.Models.Dto;

namespace Movies.Helpers
{
    public class ApplicationMapper : Profile
    {

        public ApplicationMapper() {

            CreateMap<Genre, GenreDto>().ReverseMap();

            CreateMap<Movie, MovieDto>().ReverseMap();
        }
    }
}
