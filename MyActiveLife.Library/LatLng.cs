using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MyActiveLife.Library
{
    public partial class LatLng : List<float?>, IEquatable<LatLng>
    {
        private decimal lat;
        private decimal lng;

        public decimal Latitude
        {
            get { return lat; }
            set { lat = value; }
        }
        public decimal Longitude
        {
            get { return lng; }
            set { lng = value; }
        }

        public LatLng() : base()
        {
        }

        public LatLng(decimal latitude, decimal longitude)
        {
            lat = latitude;
            lng = longitude;
        }

        public override bool Equals(object input)
        {
            return Equals(input as LatLng);
        }

        /// <summary>
        /// Returns true if LatLng instances are equal
        /// </summary>
        /// <param name="input">Instance of LatLng to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LatLng input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                return hashCode;
            }
        }
    }
}
