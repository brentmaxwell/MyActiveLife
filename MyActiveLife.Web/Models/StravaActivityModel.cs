using MyActiveLife.Apis.Google;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyActiveLife.Web.Models
{
    public class StravaActivityModel : ActivityModel
    {
        [DisplayName("Type")]
        public string Type { get; set; }

        [DisplayName("Moving Time")]
        [DataType(DataType.Duration)]
        public TimeSpan MovingTime { get; set; }

        [DisplayName("Elapsed Time")]
        [DataType(DataType.Duration)]
        public TimeSpan ElapsedTime { get; set; }

        [DisplayName("Distance")]
        public float? Distance { get; set; }

        [DisplayName("Total Elevation Gain")]
        public float? TotalElevationGain { get; set; }

        [DisplayName("Average Speed")]
        public float? AverageSpeed { get; set; }

        [DisplayName("Max Speed")]
        public float? MaxSpeed { get; set; }

        [DisplayName("Average Cadence")]
        public float? AverageCadence { get; set; }

        [DisplayName("Average Temp")]
        public float? AverageTemp { get; set; }
        
        [DisplayName("Average Watts")]
        public float? AverageWatts { get; set; }

        [DisplayName("Max Watts")]
        public float? MaxWatts { get; set; }

        [DisplayName("Weighted Average Watts")]
        public float? WeightedAverageWatts { get; set; }

        [DisplayName("Total Power Output")]
        public float? Kilojoules { get; set; }

        [DisplayName("High Elevation")]
        public float? ElevationHigh { get; set; }
        
        [DisplayName("Low Elevation")] 
        public float? ElevationLow { get; set; }

        [DisplayName("Suffer Score")]
        public float? SufferScore { get; set; }
        
        [DisplayName("Calories")]
        public float? Calories { get; set; }
    }
}
