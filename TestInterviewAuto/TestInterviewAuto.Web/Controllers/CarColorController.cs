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
        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;

        public CarColorController(IColorRepository colorRepository, IMapper mapper)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
        }
        
        [HttpPost]
        public async Task<ActionResult> CreateColor([FromBody] CreateColorDto colorDto)
        {
            var color = _mapper.Map<Color>(colorDto);
            await _colorRepository.AddAsync(color);
            await _colorRepository.Context.SaveChangesAsync();
            return Ok();
        }
    }
}