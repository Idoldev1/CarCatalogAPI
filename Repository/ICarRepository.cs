using System;
using FirstWebAPI.Models;

namespace FirstWebAPI.Data;

public interface ICarRepository
{
    IEnumerable<Car> GetAllCar();
    Car GetCar(int Id);
    Car GetCar(string name);
    bool Addcar(Car car);
    bool CarExists(int Id);
    bool Delete(int Id);
    bool Update(Car updatecar);
    bool Save();
    
}