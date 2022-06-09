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
        public float? Temperature { get; set; }
        public float? MaxTemperature { get; set; }
        public float? MinTemperature { get; set; }
        public float? Dewpoint { get; set; }
        public int? WindDirection { get; set; }
        public float? WindSpeed { get; set; }
        public float? WindGust { get; set; }
        public float? Precipitation { get; set; }
    }
}
