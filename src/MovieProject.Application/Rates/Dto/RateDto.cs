using Abp.Application.Services.Dto;
using MovieProject.Authorization.Users;
using MovieProject.Users.Dto;

namespace MovieProject.Rates.Dto;

public class RateDto : EntityDto
{
    public string Comment{ get; set; }
    public int Rating { get; set; }
    public UserDto User { get; set; }
}