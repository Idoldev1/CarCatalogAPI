using System;
using System.Collections.Generic;
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
        }
        return Save();
    }

    public bool CarExists(int Id)
    {
        return context.Cars.Any(c => c.Id == Id);
    }

    public ICollection<Car> GetAllCar()
    {
        return context.Cars.OrderBy(c => c.Id).ToList();
    }

    public Car GetCar(int id)
    {
        return context.Cars.Where(c => c.Id == id).FirstOrDefault();
    }

    public bool Update(Car updateCar)
    {
        var car = context.Cars.Attach(updateCar);
        car.State = EntityState.Modified;
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
