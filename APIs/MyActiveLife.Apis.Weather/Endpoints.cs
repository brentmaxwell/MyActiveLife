using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Weather
{
    public static class Endpoints
    {
        public const string BaseUrl = "http://www.aviationweather.gov/adds/dataserver_current/httpparam";
        public const string Metars = $"{BaseUrl}?dataSource=metars&requestType=retrieve&format=xml";
    }
}
