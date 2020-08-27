using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TestInterviewAuto.Infrastructure.Repositories.BrandRepository;
using TestInterviewAuto.Web.Dtos;

namespace TestInterviewAuto.Web.Features.Brand
{
    public class CreateBrandCommand : IRequest
    {
        public CreateBrandDto CreateBrandDto { get; set; }
    }


    public class CreateBrandCommandHandler : AsyncRequestHandler<CreateBrandCommand>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        protected override async Task Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = _mapper.Map<Domain.Model.Brand.Brand>(request.CreateBrandDto);
            await _brandRepository.AddAsync(brand);
            await _brandRepository.Context.SaveChangesAsync();
        }
    }
}
