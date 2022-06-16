using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class Split
    {
        [JsonProperty("distance")]
        public double Distance { get; set; }
        
        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }
        
        [JsonProperty("elevation_difference")]
        public double ElevationDifference { get; set; }
        
        [JsonProperty("moving_time")]
        public int MovingTime  { get; set; }
        
        [JsonProperty("split")]
        public int SplitIndex { get; set; }
        
        [JsonProperty("average_speed")]
        public double AverageSpeed { get; set; }
        
        [JsonProperty("pace_zone")]
        public int PaceZone { get; set; }
    }
}
