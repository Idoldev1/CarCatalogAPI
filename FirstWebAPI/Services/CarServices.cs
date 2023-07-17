using System;
using AutoMapper;
using FirstWebAPI.Dto;
using FirstWebAPI.Models;
using FirstWebAPI.Pagination;
using FirstWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FirstWebAPI.Services
{
    internal sealed class CarServices : ICarServices
    {
        private readonly ICarRepository repository;
        private readonly ILogger logger;
        private readonly IMapper mapper;
        private readonly RepositoryBase<Car> _repositoryBase;
        private readonly IMemoryCache memoryCache;

        public CarServices(ICarRepository _repository,
                          ILogger _logger
                          ,IMapper mapper
                          ,RepositoryBase<Car> repositoryBase
                          ,IMemoryCache memoryCache)
        {
            repository = _repository;
            logger = _logger;
            this.mapper = mapper;
            _repositoryBase = repositoryBase;
            this.memoryCache = memoryCache;
        }

        public CarDto AddCar(CarInputDto car)
        {
            var carEntity = mapper.Map<Car>(car);

            repository.AddCar(carEntity);

            var carReturn = mapper.Map<CarDto>(carEntity);

            return carReturn;
        }

        public void DeleteCar(string Id)
        {
            var car = repository.GetCar(Id);

            if (car == null)
                throw new Exception("Id not found");

            repository.DeleteCar(car);

            _repositoryBase.Save();
        }
        public CarDto GetCar(string Id)
        {
            logger.LogInformation("Request made for a specific Car using the Id");

            var cachekey = "car";
            if (!memoryCache.TryGetValue(cachekey, out IEnumerable<Car> car))
            {

                var carDto = mapper.Map<CarDto>(car);

                //Setting up cache options
                var cacheExpiryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddSeconds(60),
                    Priority = CacheItemPriority.High,
                    SlidingExpiration = TimeSpan.FromSeconds(40)
                };

                memoryCache.Set(cachekey, car, cacheExpiryOptions);
            }
            return (CarDto)car;
            
        }

        public void UpdateCar(string Id, CarInputDto carInputDto)
        {
            var car = repository.GetCar(Id);
            if (car == null)
                throw new Exception("Car not found");

            mapper.Map(carInputDto, car);

            _repositoryBase.Save();
        }
    }
}