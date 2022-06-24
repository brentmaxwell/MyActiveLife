using AutoMapper;
using MyActiveLife.Apis.Google;
using MyActiveLife.Apis.Strava.Entities;
using MyActiveLife.Database.Entities;
using MyActiveLife.Web.Models;

namespace MyActiveLife.Web.Mappings
{
    public class StravaActivityModelMapping : Profile
    {
        private string staticMapApiKey;
        public StravaActivityModelMapping()
        {
            CreateMap<StravaActivity, StravaActivityModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ActivityName))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartDateTime))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.MovingTime, opt => opt.MapFrom(src => src.MovingTime))
                .ForMember(dest => dest.ElapsedTime, opt => opt.MapFrom(src => src.ElapsedTime))
                .ForMember(dest => dest.Distance, opt => opt.MapFrom(src => src.Distance))
                .ForMember(dest => dest.TotalElevationGain, opt => opt.MapFrom(src => src.TotalElevationGain))
                .ForMember(dest => dest.AverageSpeed, opt => opt.MapFrom(src => src.AverageSpeed))
                .ForMember(dest => dest.MaxSpeed, opt => opt.MapFrom(src => src.MaxSpeed))
                .ForMember(dest => dest.AverageCadence, opt => opt.MapFrom(src => src.AverageCadence))
                .ForMember(dest => dest.AverageTemp, opt => opt.MapFrom(src => src.AverageTemp))
                .ForMember(dest => dest.AverageWatts, opt => opt.MapFrom(src => src.AverageWatts))
                .ForMember(dest => dest.MaxWatts, opt => opt.MapFrom(src => src.MaxWatts))
                .ForMember(dest => dest.WeightedAverageWatts, opt => opt.MapFrom(src => src.WeightedAverageWatts))
                .ForMember(dest => dest.Kilojoules, opt => opt.MapFrom(src => src.Kilojoules))
                .ForMember(dest => dest.ElevationHigh, opt => opt.MapFrom(src => src.ElevationHigh))
                .ForMember(dest => dest.ElevationLow, opt => opt.MapFrom(src => src.ElevationLow))
                .ForMember(dest => dest.SufferScore, opt => opt.MapFrom(src => src.SufferScore))
                .ForMember(dest => dest.Calories, opt => opt.MapFrom(src => src.Calories))
                .ForMember(dest => dest.Map, opt => opt.MapFrom(src => src.MapPolyline != null ? GetMap(src.MapPolyline) : null))
                .IncludeBase<Database.Entities.Activity, ActivityModel>();
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
