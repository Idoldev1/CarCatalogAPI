using System;
using FirstWebAPI.Dto;
using FirstWebAPI.Models;
using FirstWebAPI.Pagination;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Repository;

public interface ICarRepository
{
    public Task<PagingList<Car>> GetAllCar(PagingParameters pagingParameters);
    Car GetCar(string Id);
    Car GetCarName(string name);
    void AddCar(Car car);
    //void CarExists(int Id);
    void DeleteCar(Car car);
    void UpdateCar(string Id, CarInputDto carInputDto);
}