using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestInterviewAuto.Domain.Model.Color;
using TestInterviewAuto.Infrastructure.Repositories.CarColorRepository;
using TestInterviewAuto.Web.Dtos;
using TestInterviewAuto.Web.Features.Color;

namespace TestInterviewAuto.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {

        private readonly IMediator _mediator;
        public ColorController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        /// <summary>
        /// Добавить цвет
        /// </summary>
        /// <param name="colorDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CreateColor")]
        [ProducesResponseType(200)]
        public async Task<ActionResult> CreateColor([FromBody] CreateColorDto colorDto)
        {
            await _mediator.Send(new CreateColorCommand() {CreateColorDto = colorDto});
            return Ok();
        }

        [HttpGet]
        [Route("Colors")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<List<GetColorDto>>> GetColors()
        {
            var result = await _mediator.Send(new GetColorsCommand());
            return Ok(result);
        }
    }
}