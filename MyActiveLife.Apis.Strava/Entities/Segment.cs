using MyActiveLife.Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class Segment : Resource
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("activity_type")]
        public string ActivityType { get; set; }
        
        [JsonProperty("distance")]
        public double Distance { get; set; }
        
        [JsonProperty("average_grade")]
        public double AverageGrade { get; set; }
        
        [JsonProperty("maximum_grade")]
        public double MaximumGrade { get; set; }
        
        [JsonProperty("elevation_high")]
        public double ElevationHigh { get; set; }
        
        [JsonProperty("elevation_low")]
        public double ElevationLow { get; set; }
        
        [JsonProperty("start_latlng")]
        public LatLng StartLatLng { get; set; }
        
        [JsonProperty("end_latlng")]
        public LatLng EndLatLng { get; set; }
        
        [JsonProperty("climb_category")]
        public int ClimbCategory { get; set; }
        
        [JsonProperty("city")]
        public string City { get; set; }
        
        [JsonProperty("state")]
        public string State { get; set; }
        
        [JsonProperty("country")]
        public string Country { get; set; }
        
        [JsonProperty("private")]
        public bool Private { get; set; }
        
        [JsonProperty("hazardous")]
        public bool Hazardous { get; set; }
        
        [JsonProperty("starred")]
        public bool Starred { get; set; }
    }
}
