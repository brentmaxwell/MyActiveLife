using MyActiveLife.Apis.Weather.Entities;
using MyActiveLife.Library;
using MyActiveLife.Library.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyActiveLife.Apis.Weather
{
    public interface IWeatherService
    {
        public Task<Metar> GetMetarAsync(string stationId = null, double? latitude = null, double? longitude = null,
            int? distance = null, DateTime? startTime = null, DateTime? endTime = null);
    }

    public class WeatherClient : ApiClient, IWeatherService
    {
        public async Task<Metar> GetMetarAsync(string stationId = null, double? latitude = null, double? longitude = null,
            int? distance = null, DateTime? startTime = null, DateTime? endTime = null)
        {
            var queryString = "&";

            if (stationId != null)
            {
                queryString += "stationString=" + stationId + "&";
            }
            else if (latitude.HasValue && longitude.HasValue && distance.HasValue)
            {
                queryString += "radialDistance=" + distance.Value + ";" + longitude.Value + "," + latitude.Value + "&";
            }
            else
            {
                throw new ArgumentException("StationID or Latitude, Longitude, and Distance required.");
            }

            if (startTime.HasValue && endTime.HasValue)
            {
                queryString += "startTime=" + startTime.Value.ToUnixTime() + "&endTime=" + endTime.Value.ToUnixTime() + "&";
            }
            else
            {
                queryString += "hoursBeforeNow=3&";
            }

            //queryString = queryString.TrimEnd(new[] { '?', '&' });
            queryString += "mostRecent=true";
            var xmlData = await GetJsonRequestAsync(Endpoints.Metars + queryString);

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlData);
            string json = JsonConvert.SerializeXmlNode(xmlDoc);
            JToken jsonData = JToken.Parse(json);
            return JsonConvert.DeserializeObject<Metar>(jsonData["response"]["data"]["METAR"].ToString());
        }
    }
}
