using AutoMapper;
using FirstWebAPI.Dto;
using FirstWebAPI.Models;

namespace FirstWebAPI.Automapper;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Car, CarDto>();
        CreateMap<CarDto, Car>();
        CreateMap<CarInputDto, Car>();
    }
}