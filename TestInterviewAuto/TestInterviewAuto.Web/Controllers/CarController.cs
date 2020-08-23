using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestInterviewAuto.Domain.Model.Car;
using TestInterviewAuto.Infrastructure.Repositories.CarBrandRepository;
using TestInterviewAuto.Infrastructure.Repositories.CarColorRepository;
using TestInterviewAuto.Infrastructure.Repositories.CarRepository;

namespace TestInterviewAuto.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        private readonly ICarColorRepository _carColorRepository;
        private readonly ICarBrandRepository _carBrandRepository;

        public CarController(ICarRepository carRepository, ICarColorRepository carColorRepository,
            ICarBrandRepository carBrandRepository)
        {
            _carRepository = carRepository;
            _carColorRepository = carColorRepository;
            _carBrandRepository = carBrandRepository;
        }
    }
}