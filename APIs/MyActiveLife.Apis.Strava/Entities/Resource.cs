using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public abstract class Resource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resource_state")]
        public ResourceState? ResourceState { get; set; }
    }

    public enum ResourceState
    {
        Unknown = 0,
        Meta = 1,
        Summary = 2,
        Detailed = 3
    }
}
