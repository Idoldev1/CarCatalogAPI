using System;
using FirstWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebAPI.Data;

public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().HasData(
            new Car 
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Honda Civic",
                Brand = "Honda",
                Maker = "Honda Motor Co. Ltd",
                Seaters = 5,
                Quantity = 17,
                CountryMade = "Japan",
                DateManufactured = new DateTime(2001,07,10)
            },
            new Car 
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Ford Mustang",
                Brand = "Ford",
                Maker = "Ford Motor Co.",
                Seaters = 4,
                Quantity = 10,
                CountryMade = "United States",
                DateManufactured = new DateTime(1993,10,22)
            },
            new Car 
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Toyota Camry",
                Brand = "Toyota",
                Maker = "Toyota Motor Co.",
                Seaters = 5,
                Quantity = 7,
                CountryMade = "Japan",
                DateManufactured = new DateTime(2004,06,19)
            },
            new Car 
            {
                Id = Guid.NewGuid().ToString(),
                Name = "BMW 3 Series",
                Brand = "Bayerische Motoren Werke AG",
                Maker = "BMW",
                Seaters = 5,
                Quantity = 7,
                CountryMade = "Germany",
                DateManufactured = new DateTime(1990,12,18)
            },
            new Car 
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Chevrolet Silverado",
                Brand = "Chevrolet",
                Maker = "General Motors Company",
                Seaters = 5-6,
                Quantity = 18,
                CountryMade = "United States",
                DateManufactured = new DateTime(2000,01,14)
            },
            new Car 
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Mercedes Benz E-Class",
                Brand = "Mercedes-Benz",
                Maker = "Daimler AG",
                Seaters = 4,
                Quantity = 12,
                CountryMade = "Germany",
                DateManufactured = new DateTime(2010,03,23)
            },
            new Car 
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Hyundai Sonata",
                Brand = "Hyundai",
                Maker = "Hyundai Motor Co.",
                Seaters = 5,
                Quantity = 18,
                CountryMade = "South Korea",
                DateManufactured = new DateTime(2012,08,22)
            },
            new Car 
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Volkswagen Golf",
                Brand = "Volkswagen",
                Maker = "Volkswagen AG",
                Seaters = 4,
                Quantity = 7,
                CountryMade = "Germany",
                DateManufactured = new DateTime(2020,06,03)
            },
            new Car 
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Nissan Rogue",
                Brand = "Nissan",
                Maker = "Nissan Motor Co. Ltd.",
                Seaters = 5,
                Quantity = 20,
                CountryMade = "Japan",
                DateManufactured = new DateTime(2016,02,21)
            },
            new Car 
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Audi A4",
                Brand = "Audi",
                Maker = "Audi AG",
                Seaters = 5,
                Quantity = 4,
                CountryMade = "Germany",
                DateManufactured = new DateTime(2019,05,29)
            }
        );
    }
}