using AutoMapper;
using MyActiveLife.Apis.Google;
using MyActiveLife.Apis.Strava.Entities;
using MyActiveLife.Database.Entities;
using MyActiveLife.Web.Models;

namespace MyActiveLife.Web.Mappings
{
    public class StravaActivityMapping : Profile
    {
        private string staticMapApiKey;
        public StravaActivityMapping()
        {
            CreateMap<MyActiveLife.Apis.Strava.Entities.Activity, StravaActivity>()
                .ForMember(dest => dest.ActivityName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.StartDateTime, opt => opt.MapFrom(src => src.StartDateLocal))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ActivityTypeId, opt => opt.MapFrom(src => 1))
                .ForMember(dest => dest.MovingTime, opt => opt.MapFrom(src => src.MovingTime.HasValue ? TimeSpan.FromSeconds(src.MovingTime.Value) : new TimeSpan()))
                .ForMember(dest => dest.ElapsedTime, opt => opt.MapFrom(src => src.ElapsedTime.HasValue ? TimeSpan.FromSeconds(src.ElapsedTime.Value) : new TimeSpan()))
                .ForMember(dest => dest.Distance, opt => opt.MapFrom(src => src.Distance / 1609))
                .ForMember(dest => dest.TotalElevationGain, opt => opt.MapFrom(src => src.TotalElevationGain))
                .ForMember(dest => dest.AverageSpeed, opt => opt.MapFrom(src => src.AverageSpeed * 2.237))
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
                .ForMember(dest => dest.MapPolyline, opt => opt.MapFrom(src => src.Map.SummaryPolyline));
        }
    }
}
