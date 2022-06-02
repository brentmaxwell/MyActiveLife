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
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The sequence of values for this stream, in seconds
        /// </summary>
        [JsonProperty("data")]
        public T[] Data { get; set; }

        /// <summary>
        /// The base series used in the case the stream was downsampled May take one of the following values: distance, time
        /// </summary>
        [JsonProperty("series_type")]
        public string SeriesType { get; set; }

        /// <summary>
        /// The number of data points in this stream
        /// </summary>
        [JsonProperty("original_size")]
        public int? OriginalSize { get; set; }

        /// <summary>
        /// The level of detail (sampling) in which this stream was returned May take one of the following values: low, medium, high
        /// </summary>
        [JsonProperty("resolution")]
        public string Resolution { get; set; }
    }
}
