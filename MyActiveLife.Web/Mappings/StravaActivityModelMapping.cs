using AutoMapper;
using MyActiveLife.Apis.Google;
using MyActiveLife.Apis.Strava.Entities;
using MyActiveLife.Web.Models;

namespace MyActiveLife.Web.Mappings
{
    public class StravaActivityModelMapping : Profile
    {
        private string staticMapApiKey;
        public StravaActivityModelMapping()
        {
            CreateMap<Activity, StravaActivityModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Distance, opt => opt.MapFrom(src => src.Distance))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartDateLocal))
                .ForMember(dest => dest.MovingTime, opt => opt.MapFrom(src => src.MovingTime.HasValue ? TimeSpan.FromSeconds(src.MovingTime.Value) : new TimeSpan()))
                .ForMember(dest => dest.Distance, opt => opt.MapFrom(src => src.Distance / 1609))
                .ForMember(dest => dest.AvgSpeed, opt => opt.MapFrom(src => src.AverageSpeed * 2.237))
                .ForMember(dest => dest.Map, opt => opt.MapFrom(src => GetMap(src.Map.SummaryPolyline)));

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
