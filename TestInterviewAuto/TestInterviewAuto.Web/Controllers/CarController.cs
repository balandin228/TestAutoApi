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
        private readonly IColorRepository _colorRepository;
        private readonly IBrandRepository _brandRepository;

        public CarController(ICarRepository carRepository, IColorRepository colorRepository,
            IBrandRepository brandRepository)
        {
            _carRepository = carRepository;
            _colorRepository = colorRepository;
            _brandRepository = brandRepository;
        }
    }
}