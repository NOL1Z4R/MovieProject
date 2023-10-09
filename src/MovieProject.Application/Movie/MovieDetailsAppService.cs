using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieProject.Authorization.Users;
using MovieProject.Entities;
using MovieProject.MovieDetails.Dto;
using MovieProject.Rates.Dto;

namespace MovieProject.MovieDetails;

    [ApiController]
    [Route("/api/MovieDetail")]
public class MovieDetailsAppService:MovieProjectAppServiceBase
{
    private readonly IRepository<Movie> _movieRepository;

    public MovieDetailsAppService(IRepository<Movie> movieRepository)
    {
        _movieRepository = movieRepository;
    }

    [HttpGet]
    public async Task<List<ShowMovieDto>> ShowMovie()
    {
        // var sessionId = AbpSession.GetUserId();
        var movies = _movieRepository.GetAll()
            .Include(m=>m.Rates)
            .ToList();
        var movieDtos = ObjectMapper.Map<List<ShowMovieDto>>(movies);
        
        return movieDtos;
    }
}