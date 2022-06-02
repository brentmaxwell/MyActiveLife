using MyActiveLife.Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class StreamSet
    {
        [JsonProperty("time")]
        public Stream<int> TimeStream { get; set; }

        [JsonProperty("distance")]
        public Stream<float> DistanceStream { get; set; }

        [JsonProperty("latlng")]
        public Stream<LatLng> LatLngStream { get; set; }
        
        [JsonProperty("altitude")]
        public Stream<float> AltitudeStream { get; set; }

        [JsonProperty("velocity_smooth")]
        public Stream<float> VelocityStream { get; set; }

        [JsonProperty("heartrate")]
        public Stream<int> HeartrateStream { get; set; }

        [JsonProperty("cadence")]
        public Stream<int> CadenceStream { get; set; }

        [JsonProperty("watts")]
        public Stream<int> PowerStream { get; set; }

        [JsonProperty("temp")]
        public Stream<int> TemperatureStream { get; set; }

        [JsonProperty("moving")]
        public Stream<bool> MovingStream { get; set; }

        [JsonProperty("grade_smooth")]
        public Stream<float> GradeStream { get; set; }
    }
}
