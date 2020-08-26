using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestInterviewAuto.Domain.Model.Brand;
using TestInterviewAuto.Infrastructure.Repositories.BrandRepository;
using TestInterviewAuto.Web.Dtos;

namespace TestInterviewAuto.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public BrandController(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
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
            var brand = _mapper.Map<Brand>(createBrandDto);
            await _brandRepository.AddAsync(brand);
            await _brandRepository.Context.SaveChangesAsync();
            return Ok();
        } 
    }
}
