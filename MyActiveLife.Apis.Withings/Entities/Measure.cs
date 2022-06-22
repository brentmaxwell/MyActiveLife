using MyActiveLife.Apis.Withings.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Withings.Entities
{
    public class Measure
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public int Unit { get; set; }

        [JsonProperty("type")]
        public MeasureTypeEnum Type { get; set; }
    }
}
