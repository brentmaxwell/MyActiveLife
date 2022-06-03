using MyActiveLife.Apis.Google;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyActiveLife.Web.Models
{
    public class StravaActivityModel
    {
        [DisplayName("Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        
        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        [DisplayName("Start Time")] 
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }

        [DisplayName("Map")]
        public StaticMap Map { get; set; }

        [DisplayName("Moving Time")]
        [DataType(DataType.Duration)]
        public TimeSpan MovingTime { get; set; }

        [DisplayName("Distance")]
        public float? Distance { get; set; }

        [DisplayName("Average Speed")]
        public float? AverageSpeed { get; set; }

    }
}
