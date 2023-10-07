using System.Configuration;
using Abp.Application.Services.Dto;

namespace MovieProject.Rates.Dto;

public class CreateRateDto
{
    public string Comment{ get; set; }
    public int Rating { get; set; }
}