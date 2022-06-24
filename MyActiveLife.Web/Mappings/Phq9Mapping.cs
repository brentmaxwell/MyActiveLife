using AutoMapper;

namespace MyActiveLife.Web.Mappings
{
    public class Phq9Mapping : Profile
    {
        public Phq9Mapping()
        {
            CreateMap<MyActiveLife.Web.Models.Phq9Model, MyActiveLife.Database.Entities.Phq9>()
                .ForMember(src => src.Answer1, opt => opt.MapFrom(dest => dest.Answer1))
                .ForMember(src => src.Answer2, opt => opt.MapFrom(dest => dest.Answer2))
                .ForMember(src => src.Answer3, opt => opt.MapFrom(dest => dest.Answer3))
                .ForMember(src => src.Answer4, opt => opt.MapFrom(dest => dest.Answer4))
                .ForMember(src => src.Answer5, opt => opt.MapFrom(dest => dest.Answer5))
                .ForMember(src => src.Answer6, opt => opt.MapFrom(dest => dest.Answer6))
                .ForMember(src => src.Answer7, opt => opt.MapFrom(dest => dest.Answer7))
                .ForMember(src => src.Answer8, opt => opt.MapFrom(dest => dest.Answer8))
                .ForMember(src => src.Answer9, opt => opt.MapFrom(dest => dest.Answer9));
        }
    }
}
