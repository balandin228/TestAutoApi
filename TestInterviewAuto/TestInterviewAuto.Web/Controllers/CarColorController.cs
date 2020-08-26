using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestInterviewAuto.Domain.Model.Color;
using TestInterviewAuto.Infrastructure.Repositories.CarColorRepository;
using TestInterviewAuto.Web.Dtos;

namespace TestInterviewAuto.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarColorController : ControllerBase
    {
        private readonly ICarColorRepository _carColorRepository;
        private readonly IMapper _mapper;

        public CarColorController(ICarColorRepository carColorRepository, IMapper mapper)
        {
            _carColorRepository = carColorRepository;
            _mapper = mapper;
        }
        
        [HttpPost]
        public async Task<ActionResult> CreateColor([FromBody] CreateColorDto colorDto)
        {
            var color = _mapper.Map<Color>(colorDto);
            await _carColorRepository.AddAsync(color);
            await _carColorRepository.Context.SaveChangesAsync();
            return Ok();
        }
    }
}