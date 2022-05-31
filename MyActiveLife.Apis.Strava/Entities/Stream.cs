using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class Stream<T>
    {
        //Stream types
        //Streams are available in 11 different types. If the stream is not available for a particular activity it will be left out of the request results.

        //time:	integer seconds
        //latlng:	floats [latitude, longitude]
        //distance:	float meters
        //altitude:	float meters
        //velocity_smooth:	float meters per second
        //heartrate:	integer BPM
        //cadence:	integer RPM
        //watts:	integer watts
        //temp:	integer degrees Celsius
        //moving:	boolean
        //grade_smooth:	float percent

        [JsonProperty("type")]
        public string Type { get; set; }

        //array of stream values
        [JsonProperty("data")]
        public T[] Data { get; set; }

        //series type used for down sampling, will be present even if not used
        [JsonProperty("series_type")]
        public string SeriesType { get; set; }

        //complete stream length
        [JsonProperty("original_size")]
        public int? OriginalSize { get; set; }

        //‘low’, ‘medium’ or ‘high’
        [JsonProperty("resolution")]
        public string Resolution { get; set; }
    }
}
