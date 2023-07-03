using AutoMapper;
using FirstWebAPI.Data;
using FirstWebAPI.Dto;
using FirstWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly ICarRepository carRepository;
        private readonly IMapper mapper;
        private readonly ILogger<CarController> logger;
        private readonly IMemoryCache _memoryCache;

        public CarController(ICarRepository carRepository
                            ,IMapper mapper, ILogger<CarController> logger
                            ,IMemoryCache memoryCache)
        {
            this.carRepository = carRepository;
            this.mapper = mapper;
            this.logger = logger;
            _memoryCache = memoryCache;
        }



        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Car>))]
        public IActionResult GetAllCar()
        {
            logger.LogInformation("Request made for get all Car");

            var cachekey = "cars";
            if (!_memoryCache.TryGetValue(cachekey, out IEnumerable<Car> cars))
            {
                cars = carRepository.GetAllCar();

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                //Setting up cache options
                var cacheExpiryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddSeconds(60),
                    Priority = CacheItemPriority.High,
                    SlidingExpiration = TimeSpan.FromSeconds(40)
                };

                //Setting cache entries
                _memoryCache.Set(cachekey, cars, cacheExpiryOptions);
            }

            return Ok(cars);
        }


        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Car))]
        [ProducesResponseType(400)]
        public IActionResult GetCar(int id)
        {
            logger.LogInformation("Request made for a specific Car using the Id");

            var cachekey = "car";
            if (!_memoryCache.TryGetValue(cachekey, out IEnumerable<Car> car))
            {
                if (!carRepository.CarExists(id))
                {
                    return NotFound();
                }

                var carId = mapper.Map<CarDto>(carRepository.GetCar(id));

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                //Setting up cache options
                var cacheExpiryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddSeconds(60),
                    Priority = CacheItemPriority.High,
                    SlidingExpiration = TimeSpan.FromSeconds(40)
                };

                _memoryCache.Set(cachekey, car, cacheExpiryOptions);
            }
            return Ok(car);
        }


        [HttpPost]
        [Authorize]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult Addcar(CarDto carCreate)
        {
            if (carCreate == null)
            {
                return BadRequest(ModelState);
            }

            var car = carRepository.GetAllCar()
                .Where(c => c.Name.Trim().ToUpper() == carCreate.Name.TrimEnd().ToUpper()).FirstOrDefault();


            if (car != null)
            {
                ModelState.AddModelError("", "Owner already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var carMap = mapper.Map<Car>(carCreate);

            if (!carRepository.Addcar(carMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully created");
        }



        [HttpPut("{id}")]
        [Authorize]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult Update(int id, [FromBody] CarDto updateCar)
        {
            if (updateCar == null)
                return BadRequest(ModelState);

            if (id != updateCar.Id)
                return BadRequest(ModelState);


            if (!carRepository.CarExists(id))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var carMap = mapper.Map<Car>(updateCar);

            if (!carRepository.Update(carMap))
            {
                ModelState.AddModelError("", "Something went wrong updating owner");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }



        [HttpDelete("(carId)")]
        [Authorize]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult Delete(int id)
        {
            if (!carRepository.CarExists(id))
            {
                return NotFound();
            }

            var carDelete = carRepository.CarExists(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if(!carRepository.Delete(id))
            {
                ModelState.AddModelError("", "Something went wrong deleting data");
            }
            return NoContent();
        }
    }
}