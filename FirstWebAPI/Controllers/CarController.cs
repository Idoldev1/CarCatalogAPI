using AutoMapper;
using FirstWebAPI.Data;
using FirstWebAPI.Dto;
using FirstWebAPI.Models;
using FirstWebAPI.Pagination;
using FirstWebAPI.Repository;
using FirstWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly IServices _service;
        private readonly IMapper mapper;
        private readonly ICarRepository _carRepository;

        public CarController(IServices service, IMapper mapper, ICarRepository carRepository)
        {
            _service = service;
            this.mapper = mapper;
            _carRepository = carRepository;
        }



        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<IEnumerable<Car>>> GetAllCar([FromBody] PagingParameters pagingParameters)
        {
            return await _carRepository.GetAllCar(pagingParameters);
        }


        [HttpGet("{Id}")]
        [ProducesResponseType(200, Type = typeof(Car))]
        [ProducesResponseType(400)]
        public IActionResult GetCar(string Id)
        {
            var car = _service.CarServices.GetCar(Id);

            return Ok(car);
        }


        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult Addcar([FromBody]CarInputDto carCreate)
        {
            if (carCreate == null)
                return BadRequest(ModelState);

            return Ok("Succesfully created");
        }



        [HttpPut("{Id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateCar(string Id, [FromBody] CarInputDto updateCar)
        {
            if (updateCar == null)
                return BadRequest(ModelState);

            _service.CarServices.UpdateCar(Id, updateCar);

            return NoContent();
        }



        [HttpDelete("(carId)")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult Delete(string Id)
        {
            if (Id == null)
            {
                return BadRequest(ModelState);
            }

            _service.CarServices.DeleteCar(Id);

            return NoContent();
        }

    }
}