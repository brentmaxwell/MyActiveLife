using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class ActivityStream
    {
        public int Time { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public float? Distance { get; set; }
        public float? Altitude { get; set; }
        public float? Velocity { get; set; }
        public int? Heartrate { get; set; }
        public int? Cadence { get; set; }
        public int? Watts { get; set; }
        public float? Temp { get; set; }
        public bool? Moving { get; set; }
        public float? Grade { get; set; }
    }
}
