using AutoMapper;
using MyActiveLife.Apis.Google;
using MyActiveLife.Apis.Strava.Entities;
using MyActiveLife.Database.Entities;
using MyActiveLife.Web.Models;

namespace MyActiveLife.Web.Mappings
{
    public class ActivityModelMapping : Profile
    {
        private string staticMapApiKey;
        public ActivityModelMapping()
        {
            CreateMap<Database.Entities.Activity, ActivityModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ActivityName))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartDateTime))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .IncludeAllDerived();
        }

        public StaticMap GetMap(string polyline)
        {
            return new StaticMap()
            {
                Height = 200,
                Width = 200,
                Path = new Apis.Google.Path()
                {
                    PathLine = "enc:" + polyline
                }
            };
        }
    }
}
