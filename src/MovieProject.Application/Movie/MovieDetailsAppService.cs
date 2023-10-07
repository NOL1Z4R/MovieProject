using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieProject.Entities;
using MovieProject.MovieDetails.Dto;

namespace MovieProject.MovieDetails;

    [ApiController]
    [Route("/apiMovieDetail")]
public class MovieDetailsAppService:MovieProjectAppServiceBase
{
    private readonly IRepository<Movie> _movieRepository;

    public MovieDetailsAppService(IRepository<Movie> movieRepository)
    {
        _movieRepository = movieRepository;
    }

    [HttpGet]
    public async Task<List<MovieDto>> ShowMovie()
    {
        var sessionId = AbpSession.GetUserId();
        var movies = _movieRepository.GetAll().Include(r=>r.User);
        var movieDtos = ObjectMapper.Map<List<MovieDto>>(movies);
        
        return movieDtos;
    }
}