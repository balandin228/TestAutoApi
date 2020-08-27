using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestInterviewAuto.Domain.Model.Brand;
using TestInterviewAuto.Infrastructure.Repositories.BrandRepository;
using TestInterviewAuto.Web.Dtos;
using TestInterviewAuto.Web.Features.Brand;

namespace TestInterviewAuto.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandController(IMediator mediator)
        {
            _mediator = mediator;
        }


        /// <summary>
        /// Добавить брэнд
        /// </summary>
        /// <param name="createBrandDto"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        [Route("CreateBrand")]
        public async Task<ActionResult> CreateBrand([FromBody] CreateBrandDto createBrandDto)
        {
            await _mediator.Send(new CreateBrandCommand(){CreateBrandDto = createBrandDto});
            return Ok();
        } 
    }
}
