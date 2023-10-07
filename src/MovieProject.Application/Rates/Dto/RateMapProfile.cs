using AutoMapper;
using MovieProject.Entities;

namespace MovieProject.Rates.Dto;

public class RateMapProfile: Profile
{
    public RateMapProfile()
    {
        CreateMap<CreateRateDto, Rate>(); // sol source sağ destinaiton
        CreateMap<Rate, RateDto>().ReverseMap();
    }
}