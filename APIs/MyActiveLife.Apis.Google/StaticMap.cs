using MyActiveLife.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Google
{
    public class StaticMap
    {
        private const string baseUrl = "https://maps.googleapis.com/maps/api/staticmap";
        /// <summary>
        /// Google Static Maps API Key
        /// </summary>
        public string ApiKey;

        /// <summary>
        /// Height of the resulting image, in pixels
        /// </summary>
        public int? Height;

        /// <summary>
        /// Width of the resulting image, in pixels
        /// </summary>
        public int? Width;
        
        /// <summary>
        /// LatLng object of the center of the map
        /// </summary>
        public LatLng Center;


        /// <summary>
        /// Zoom level
        /// </summary>
        public int? Zoom;


        /// <summary>
        /// Path to display on the map
        /// </summary>
        public Path Path;

        /// <summary>
        /// Initializes new Static Map class
        /// </summary>
        /// <param name="apiKey">Google Static Maps API Key</param>
        public StaticMap(string apiKey = null)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Returns a static map image URL as a string
        /// </summary>
        /// <returns>image URL</returns>
        public override string ToString()
        {
            var output = baseUrl + "?";
            if(Height.HasValue && Width.HasValue)
            {
                output += $"size={Height}x{Width}&";
            }
            if(Center != null)
            {
                output += $"center={Center.Latitude},{Center.Longitude}&";
            }
            if(Zoom.HasValue)
            {
                output += $"zoom={Zoom.Value}&";
            }
            output += $"path={Path.ToString()}&key={ApiKey}";
            return output;
        }
    }
    public class Path
    {
        public int? Weight;
        public string Color;
        public string FillColor;
        public bool Geodesic;
        public string PathLine;

        public override string ToString()
        {
            string output = "";
            if (Weight.HasValue)
            {
                output += "weight:" + Weight.Value + "|";
            }
            if(Color != null)
            {
                output += "color:" + Color + "|";
            }
            if (FillColor != null)
            {
                output += "fillcolor:" + FillColor + "|";
            }
            if (Geodesic)
            {
                output += "geodesic:true|";
            }
            output += PathLine;
            return output;
        }

    }
}
