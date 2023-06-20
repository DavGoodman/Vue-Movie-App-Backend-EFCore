using AutoMapper;
using EFCoreMoviesForVue.DTOs;

namespace EFCoreMoviesForVue.Entities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() {
            
            CreateMap<Movie, MovieDTO>().ForMember(dto => dto.Genres, 
                    ent => ent.MapFrom(src => src.MovieGenres
                        .Select(x => x.Genre.Name)));

            CreateMap<Genre, GenreDTO>().ForMember(dto => dto.Movies,
                    ent => ent.MapFrom(src => src.MovieGenres
                        .Select(x => x.Movie)));

        }
    }
}
