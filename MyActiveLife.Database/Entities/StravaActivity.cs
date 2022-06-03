using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    [Table("StravaActivity")]
    public class StravaActivity : Activity
    {
        public TimeSpan MovingTime { get; set; }
        public TimeSpan ElapsedTime { get; set; }
        public float? Distance { get; set; }
        public float? AverageSpeed { get; set; }
        public float? MaxSpeed { get; set; }
        public float? AverageCadence { get; set; }
        public float? AverageTemp { get; set; }
        public float? AverageWatts { get; set; }
        public float? MaxWatts { get; set; }
        public float? WeightedAverageWatts { get; set; }
        public float? Kilojoules { get; set; }
        public float? ElevationHigh { get; set; }
        public float? ElevationLow { get; set; }
        public float? SufferScore { get; set; }
        public float? Calories { get; set; }
        public string MapPolyline { get; set; }
        
    }
}
