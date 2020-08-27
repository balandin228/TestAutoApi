using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TestInterviewAuto.Infrastructure.Repositories.CarColorRepository;
using TestInterviewAuto.Web.Dtos;

namespace TestInterviewAuto.Web.Features.Color
{
    public class CreateColorCommand : IRequest
    {
        public CreateColorDto CreateColorDto { get; set; }
    }


    public class CreateColorCommandHandler : AsyncRequestHandler<CreateColorCommand>
    {
        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;

        public CreateColorCommandHandler(IColorRepository colorRepository, IMapper mapper)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
        }
        protected override async Task Handle(CreateColorCommand request, CancellationToken cancellationToken)
        {
            var color = _mapper.Map<Domain.Model.Color.Color>(request.CreateColorDto);
            await _colorRepository.AddAsync(color);
            await _colorRepository.Context.SaveChangesAsync();
        }
    }
}
