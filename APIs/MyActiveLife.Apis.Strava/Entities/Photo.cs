using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class Photo
    {
        /// <summary>
        /// The number of photos
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("primary")]
        public PrimaryPhoto PrimaryPhoto { get; set; }
    }

    public class PrimaryPhoto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("urls")]
        public string Urls { get; set; }
    }
}
