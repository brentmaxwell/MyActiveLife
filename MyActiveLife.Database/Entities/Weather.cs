using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    public class Weather
    {
        [Key]
        public Guid WeatherId { get; set; }
        public string StationId { get; set; }
        public string ZipCode { get; set; }
        public DateTime DateTime { get; set; }
        public float HighTemp { get; set; }
        public float LowTemp { get; set; }
        public float Humidity { get; set; }
        public float Precipitation { get; set; }
        public float CloudCover { get; set; }
    }
}
