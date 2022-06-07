using MyActiveLife.Apis.Weather.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Weather
{
    public class WeatherClient
    {
        public WeatherClient()
        {

        }

        public DailyWeather GetWeather(DateTime date)
        {
            return new DailyWeather();
        }

        public ICollection<DailyWeather> GetWeather(DateTime startDate, DateTime endDate)
        {
            return new List<DailyWeather>();
        }
    }
}
