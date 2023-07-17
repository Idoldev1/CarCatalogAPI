using FirstWebAPI.Dto;
using FirstWebAPI.Models;
using FirstWebAPI.Pagination;

namespace FirstWebAPI.Services;

public interface ICarServices
{
    CarDto GetCar(string Id);
    CarDto AddCar(CarInputDto car);
    void DeleteCar(string Id);
    void UpdateCar(string Id, CarInputDto carInputDto);
}