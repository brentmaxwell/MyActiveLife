using MyActiveLife.Apis.Google;
using System.ComponentModel;

namespace MyActiveLife.Web.Models
{
    public class StravaActivityModel
    {
        [DisplayName("Name")]
        public string Name { get; set; }
        
        [DisplayName("Description")]
        public string Description { get; set; }
        
        [DisplayName("Start Time")] 
        public DateTime StartTime { get; set; }

        [DisplayName("Map")]
        public StaticMap Map { get; set; }

        [DisplayName("Moving Time")]
        public TimeSpan MovingTime { get; set; }

        [DisplayName("Distance")]
        public decimal? Distance { get; set; }

        [DisplayName("Average Speed")]
        public decimal? AvgSpeed { get; set; }

    }
}
