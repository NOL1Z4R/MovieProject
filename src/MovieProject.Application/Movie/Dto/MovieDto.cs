using MovieProject.Users.Dto;

namespace MovieProject.MovieDetails.Dto;

public class MovieDto
{
    public string Description { get; set; }
    public int Rate { get; set; }
    public UserDto User { get; set; }
}