using AutoMapper;
using MovieProject.Entities;
using MovieProject.Rates.Dto;

namespace MovieProject.MovieDetails.Dto;

public class MovieMapProfile: Profile
{
    public MovieMapProfile()
    {
        CreateMap<Movie, ShowMovieDto>().ReverseMap();
    }
}