using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class Bike : Gear
    {
        //bike only 
        //1 -> mtb, 2 -> cross, 3 -> road, 4 -> time trial
        [JsonProperty("frame_type")]
        public FrameType FrameType { get; set; }
    }

    public enum FrameType
    {
        Unknwon = 0,
        MTB = 1,
        Cross = 2,
        Road = 3,
        TimeTrial = 4
    }
}
