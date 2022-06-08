using MyActiveLife.Apis.Weather.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Weather.Entities
{
    public class Metar
    {
        //The raw METAR
        [JsonProperty("raw_text")]
        public string RawText { get; set; }

        //Station identifier; Always a four character alphanumeric( A-Z, 0-9)
        [JsonProperty("station_id")]
        public string StationId { get; set; }

        //Time( in ISO8601 date/time format) this METAR was observed.
        [JsonProperty("observation_time")]
        public DateTime ObservationTime { get; set; }

        //The latitude (in decimal degrees )of the station that reported this METAR
        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        //The longitude (in decimal degrees) of the station that reported this METAR
        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        //Air temperature
        // degrees celsius
        [JsonProperty("temp_c")]
        public double? Temp { get; set; }

        //Dewpoint temperature
        // degrees celsius
        [JsonProperty("dewpoint_c")]
        public double? Dewpoint { get; set; }

        //Direction from which the wind is blowing. 
        // degrees from N
        [JsonProperty("wind_dir_degrees")]
        public int? WindDirection { get; set; }

        //Wind speed; 0 degree wdir and 0 wspd = calm winds
        // knots
        [JsonProperty("wind_speed_kt")]
        public int? WindSpeed { get; set; }

        //Wind gust
        // knots
        [JsonProperty("wind_gust_kt")]
        public int? WindGust { get; set; }

        //Horizontal visibility
        // statute miles
        [JsonProperty("visibility_statute_mi")]
        public double? Visibility { get; set; }

        //Altimeter
        // inches of Hg
        [JsonProperty("altim_in_hg")]
        public double? Altimiter { get; set; }

        //Sea-level pressure
        // millibars
        [JsonProperty("sea_level_pressure_mb")]
        public double? SeaLevelPressure { get; set; }

        ////Quality control flags (see below) provide useful information about the METAR station(s) that provide the data.
        //[JsonProperty("quality_control_flags")]
        //public string QualityControlFlags { get; set; }

        [JsonProperty("wx_string")]
        public string WeatherString { get; set; }

        [JsonProperty("sky_condition")]
        public ICollection<SkyCondition> SkyCondition { get; set; }

        //Flight category of this METAR. Values: VFR|MVFR|IFR|LIFR 
        [JsonProperty("flight_category")]
        public FlightCategoryEnum FlightCategory { get; set; }

        //Pressure change in the past 3 hours
        // millibars
        [JsonProperty("three_hr_pressure_tendency_mb")]
        public double? ThreeHourPressureTendency { get; set; }

        //Maximum air temperature from the past 6 hours
        // degrees celsius
        [JsonProperty("maxT_c")]
        public double? MaxTemperature { get; set; }

        //Minimum air temperature from the past 6 hours
        // degrees celsius
        [JsonProperty("minT_c")]
        public double? MinTemperature { get; set; }

        //Maximum air temperature from the past 24 hours
        // degrees celsius
        [JsonProperty("maxT24hr_c")]
        public double? MaxTemperature24Hours { get; set; }

        //Minimum air temperature from the past 24 hours
        // degrees celsius
        [JsonProperty("minT24hr_c")]
        public double? MinTemperature24Hours { get; set; }

        //Liquid precipitation since the last regular METAR
        // inches
        [JsonProperty("precip_in")]
        public double? Precipitation { get; set; }

        //Liquid precipitation from the past 3 hours. 0.0005 in = trace precipitation
        // inches
        [JsonProperty("pcp3hr_in")]
        public double? Precipitation3Hours { get; set; }

        //Liquid precipitation from the past 6 hours. 0.0005 in = trace precipitation
        // inches
        [JsonProperty("pcp6hr_in")]
        public double? Precipitation6Hours { get; set; }

        //Liquid precipitation from the past 24 hours. 0.0005 in = trace precipitation
        // inches
        [JsonProperty("pcp24hr_in")]
        public double? Precipitation24Hours { get; set; }

        //Snow depth on the ground
        // inches
        [JsonProperty("snow_in")]
        public double? Snow { get; set; }

        //Vertical Visibility
        // feet
        [JsonProperty("vert_vis_ft")]
        public int? VerticalVisibility { get; set; }

        [JsonProperty("metar_type")]
        public MetarTypeEnum MetarType { get; set; }

        //The elevation of the station that reported this METAR
        // meters
        [JsonProperty("elevation_m")]
        public double? Elevation { get; set; }
    }
}
