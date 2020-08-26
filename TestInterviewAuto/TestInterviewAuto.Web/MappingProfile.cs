using AutoMapper;
using TestInterviewAuto.Domain.Model.Color;
using TestInterviewAuto.Web.Dtos;

namespace TestInterviewAuto.Web
{
    public class MappingProfile  : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateColorDto, Color>()
                .ForMember(x=>x.Hex,
                    opt=>opt.MapFrom(c=>c.Hex))
                .ForMember(x=>x.Name,
                    opt=>opt.MapFrom(c=>c.Name));
        }
    }
}