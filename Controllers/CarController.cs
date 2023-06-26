using AutoMapper;
using FirstWebAPI.Data;
using FirstWebAPI.Dto;
using FirstWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly ICarRepository carRepository;
        private readonly IMapper mapper;

        public CarController(ICarRepository carRepository, IMapper mapper)
        {
            this.carRepository = carRepository;
            this.mapper = mapper;
        }



        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Car>))]
        public IActionResult GetAllCar()
        {
            var car = carRepository.GetAllCar();

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(car);
        }


        [HttpGet("{Id}")]
        [ProducesResponseType(200, Type = typeof(Car))]
        [ProducesResponseType(400)]
        public IActionResult GetCar(int? id)
        {
            if (!carRepository.CarExists(id ?? 1))
            {
                return NotFound();
            }
            
            var car = mapper.Map<CarDto>(carRepository.GetCar(id ?? 1));

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(car);
        }


        [HttpPost]
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



        [HttpPut("{Id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult Update(int Id, [FromBody] CarDto updateCar)
        {
            if (updateCar == null)
                return BadRequest(ModelState);

            if (Id != updateCar.Id)
                return BadRequest(ModelState);


            if (!carRepository.CarExists(Id))
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
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult Delete(int Id)
        {
            if (!carRepository.CarExists(Id))
            {
                return NotFound();
            }

            var carDelete = carRepository.CarExists(Id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if(!carRepository.Delete(Id))
            {
                ModelState.AddModelError("", "Something went wrong deleting data");
            }
            return NoContent();
        }

    }
}