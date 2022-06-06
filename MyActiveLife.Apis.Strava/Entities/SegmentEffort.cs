using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class SegmentEffort : Resource
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("activity")]
        public Activity Activity { get; set; }
        
        [JsonProperty("athlete")]
        public Athlete Athlete { get; set; }
        
        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }
        
        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }
        
        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }
        
        [JsonProperty("start_date_local")]
        public DateTime StartDateLocatl { get; set; }
        
        [JsonProperty("distance")]
        public double Distance { get; set; }
        
        [JsonProperty("start_index")]
        public int StartIndex { get; set; }
        
        [JsonProperty("end_index")]
        public int EndIndex { get; set; }
        
        [JsonProperty("average_cadence")]
        public double AverageCadence { get; set; }
        
        [JsonProperty("device_watts")]
        public double DeviceWatts { get; set; }
        
        [JsonProperty("average_watts")]
        public double AverageWatts { get; set; }
        
        [JsonProperty("segment")]
        public Segment Segment { get; set; }
        
        [JsonProperty("kom_rank")]
        public int KomRank { get; set; }
        
        [JsonProperty("pr_rank")]
        public int PrRank { get; set; }
        
        [JsonProperty("achievements")]
        public ICollection<Achievement> Achievements { get; set; }
        
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }
    }
}
