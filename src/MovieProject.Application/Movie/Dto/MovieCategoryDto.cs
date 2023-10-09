using Abp.Application.Services.Dto;

namespace MovieProject.MovieDetails.Dto;

public class MovieCategoryDto:EntityDto
{
    public Categories Category { get; set; }
    public string Email { get; set; }
}