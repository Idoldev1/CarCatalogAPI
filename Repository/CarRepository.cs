using System;
using FirstWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebAPI.Data;

public class CarRepository : ICarRepository
{
    private readonly AppDbContext context;

    public CarRepository(AppDbContext context)
    {
        this.context = context;
    }




    public bool Addcar(Car car)
    {
        context.Cars.Add(car);
        return Save();
    }


    public bool Delete(int Id)
    {
        Car car = context.Cars.Find(Id);
        if (car != null)
        {
            context.Cars.Remove(car);
            context.SaveChanges();
        }
        return Save();
    }

    public bool CarExists(int Id)
    {
        return context.Cars.Any(c => c.Id == Id);
    }

    public IEnumerable<Car> GetAllCar()
    {
        return context.Cars;
    }

    public Car GetCar(int Id)
    {
        return context.Cars.Find(Id);
    }

    public bool Update(Car updateCar)
    {
        var car = context.Cars.Attach(updateCar);
        car.State = EntityState.Modified;
        context.SaveChanges();
        return Save();
    }

    public Car GetCar(string name)
    {
        return context.Cars.Where(c => c.Name == name).FirstOrDefault();
    }

    public bool Save()
    {
        var saved = context.SaveChanges();
        return saved > 0 ? true : false;
    }
}
