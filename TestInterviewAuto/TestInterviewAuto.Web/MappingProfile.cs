using AutoMapper;
using TestInterviewAuto.Domain.Model.Brand;
using TestInterviewAuto.Domain.Model.Car;
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

            CreateMap<CreateCarDto, Car>()
                .ForMember(x => x.RegistrationNumber,
                    opt => opt.MapFrom(x => x.RegistrationNumber))
                .ForMember(x => x.YearOfIssue,
                    opt => opt.MapFrom(x => x.YearOfIssue));

            CreateMap<CreateBrandDto, Brand>()
                .ForMember(x => x.Name,
                    opt => opt.MapFrom(x => x.Name));
        }
    }
}