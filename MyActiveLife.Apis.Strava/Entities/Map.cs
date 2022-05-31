using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class Map : Resource
    {
        [JsonProperty("polyline")]
        public string Polyline { get; set; }
        
        [JsonProperty("summary_polyline")]
        public string SummaryPolyline { get; set; }
    }
}
