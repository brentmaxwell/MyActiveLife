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

        private string _apiKey;
        public int? Height;
        public int? Width;
        private string size
        {
            get 
            {
                return Height.HasValue && Width.HasValue ? $"{Height}x{Width}": null;

            }
        }

        public LatLng Center;

        public int? Zoom;

        public Path Path;

        public StaticMap(string apiKey)
        {
            _apiKey = apiKey;
        }

        public override string ToString()
        {
            var output = baseUrl + "?";
            if(size != null)
            {
                output += $"size={size}&";
            }
            if(Center != null)
            {
                output += $"center={Center.Latitude},{Center.Longitude}&";
            }
            if(Zoom.HasValue)
            {
                output += $"zoom={Zoom.Value}&";
            }
            output += $"path={Path.ToString()}&key={_apiKey}";
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
