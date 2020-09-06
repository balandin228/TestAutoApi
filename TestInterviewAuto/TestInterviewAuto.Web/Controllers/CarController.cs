using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestInterviewAuto.Domain.Model.Car;
using TestInterviewAuto.Domain.Model.CarBrand;
using TestInterviewAuto.Domain.Model.CarColor;
using TestInterviewAuto.Infrastructure.Repositories.BrandRepository;
using TestInterviewAuto.Infrastructure.Repositories.CarBrandRepository;
using TestInterviewAuto.Infrastructure.Repositories.CarColorRepository;
using TestInterviewAuto.Infrastructure.Repositories.CarRepository;
using TestInterviewAuto.Web.Dtos;

namespace TestInterviewAuto.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        private readonly ICarColorRepository _carColorRepository;
        private readonly ICarBrandRepository _carBrandRepository;
        private readonly IMapper _mapper;

        public CarController(ICarRepository carRepository, ICarColorRepository carColorRepository,
            ICarBrandRepository carBrandRepository, IMapper mapper)
        {
            _mapper = mapper;
            _carRepository = carRepository;
            _carBrandRepository = carBrandRepository;
            _carColorRepository = carColorRepository;
        }

        /// <summary>
        /// Добавить автомобиль
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        [Route("CreateCar")]
        public async Task<ActionResult> CreateCar([FromBody] CreateCarDto createCarDto)
        {
            var car = _mapper.Map<Car>(createCarDto);
            await _carRepository.AddAsync(car);
            await _carRepository.Context.SaveChangesAsync();
            var carColor = new CarColor(car.Key,createCarDto.ColorId);
            await _carColorRepository.AddAsync(carColor);
            var carBrand = new CarBrand(car.Key,createCarDto.CarBrandId);
            await _carBrandRepository.AddAsync(carBrand);
            await _carColorRepository.Context.SaveChangesAsync();
            return Ok();
        }


        [HttpPost]
        [ProducesResponseType(200)]
        [Route("All")]
        public async Task<ActionResult<List<GetCarDto>>> GetAllCars()
        {
            var result =await _carRepository.ListAsync();
            return _mapper.Map<List<GetCarDto>>(result);
        }
    }
}