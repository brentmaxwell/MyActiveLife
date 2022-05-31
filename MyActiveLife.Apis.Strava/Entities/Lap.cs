using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class Lap
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("resource_state")]
        public int ResourceState { get; set; }
        
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
        
        [JsonProperty("total_elevation_gain")]
        public int TotalElevationGain { get; set; }
        
        [JsonProperty("average_speed")]
        public double AverageSpeed { get; set; }
        
        [JsonProperty("max_speed")]
        public double MaxSpeed { get; set; }
        
        [JsonProperty("average_cadence")]
        public double AverageCadence { get; set; }
        
        [JsonProperty("device_watts")]
        public double DeviceWatts { get; set; }
        
        [JsonProperty("average_watts")]
        public double AverageWatts { get; set; }
        
        [JsonProperty("lap_index")]
        public int LapIndex { get; set; }
        
        [JsonProperty("split")]
        public int split { get; set; }
    }
}
