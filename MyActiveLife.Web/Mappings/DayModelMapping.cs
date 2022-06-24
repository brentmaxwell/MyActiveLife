using AutoMapper;
using MyActiveLife.Apis.Google;
using MyActiveLife.Apis.Strava.Entities;
using MyActiveLife.Database.Entities;
using MyActiveLife.Web.Models;

namespace MyActiveLife.Web.Mappings
{
    public class DayModelMapping : Profile
    {
        private string staticMapApiKey;
        public DayModelMapping()
        {
            CreateMap<Day, DayModel>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.Phq9s, opt => opt.MapFrom(src => src.Phq9s))
                .ForMember(dest => dest.Activities, opt => opt.MapFrom(src => src.Activities));
        }
    }
}
