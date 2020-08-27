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
    public class GetColorsCommand : IRequest<List<GetColorDto>>
    {
    }


    public class GetColorsCommandHandler : IRequestHandler<GetColorsCommand,List<GetColorDto>>
    {
        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;

        public GetColorsCommandHandler(IColorRepository colorRepository, IMapper mapper)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
        }

        public async Task<List<GetColorDto>> Handle(GetColorsCommand request, CancellationToken cancellationToken)
        {
            var colors = await _colorRepository.ListAsync();
            return _mapper.Map<List<GetColorDto>>(colors);
        }
    }
}
