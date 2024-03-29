/*
 * Strava API v3
 *
 * The [Swagger Playground](https://developers.strava.com/playground) is the easiest way to familiarize yourself with the Strava API by submitting HTTP requests and observing the responses before you write any client code. It will show what a response will look like with different endpoints depending on the authorization scope you receive from your athletes. To use the Playground, go to https://www.strava.com/settings/api and change your “Authorization Callback Domain” to developers.strava.com. Please note, we only support Swagger 2.0. There is a known issue where you can only select one scope at a time. For more information, please check the section “client code” at https://developers.strava.com/docs.
 *
 * OpenAPI spec version: 3.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class BaseStream : IEquatable<BaseStream>
    { 
        /// <summary>
        /// The number of data points in this stream
        /// </summary>
        /// <value>The number of data points in this stream</value>

        [DataMember(Name="original_size")]
        public int? OriginalSize { get; set; }

        /// <summary>
        /// The level of detail (sampling) in which this stream was returned
        /// </summary>
        /// <value>The level of detail (sampling) in which this stream was returned</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ResolutionEnum
        {
            /// <summary>
            /// Enum LowEnum for low
            /// </summary>
            [EnumMember(Value = "low")]
            LowEnum = 0,
            /// <summary>
            /// Enum MediumEnum for medium
            /// </summary>
            [EnumMember(Value = "medium")]
            MediumEnum = 1,
            /// <summary>
            /// Enum HighEnum for high
            /// </summary>
            [EnumMember(Value = "high")]
            HighEnum = 2        }

        /// <summary>
        /// The level of detail (sampling) in which this stream was returned
        /// </summary>
        /// <value>The level of detail (sampling) in which this stream was returned</value>

        [DataMember(Name="resolution")]
        public ResolutionEnum? Resolution { get; set; }

        /// <summary>
        /// The base series used in the case the stream was downsampled
        /// </summary>
        /// <value>The base series used in the case the stream was downsampled</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SeriesTypeEnum
        {
            /// <summary>
            /// Enum DistanceEnum for distance
            /// </summary>
            [EnumMember(Value = "distance")]
            DistanceEnum = 0,
            /// <summary>
            /// Enum TimeEnum for time
            /// </summary>
            [EnumMember(Value = "time")]
            TimeEnum = 1        }

        /// <summary>
        /// The base series used in the case the stream was downsampled
        /// </summary>
        /// <value>The base series used in the case the stream was downsampled</value>

        [DataMember(Name="series_type")]
        public SeriesTypeEnum? SeriesType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseStream {\n");
            sb.Append("  OriginalSize: ").Append(OriginalSize).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  SeriesType: ").Append(SeriesType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((BaseStream)obj);
        }

        /// <summary>
        /// Returns true if BaseStream instances are equal
        /// </summary>
        /// <param name="other">Instance of BaseStream to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseStream other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OriginalSize == other.OriginalSize ||
                    OriginalSize != null &&
                    OriginalSize.Equals(other.OriginalSize)
                ) && 
                (
                    Resolution == other.Resolution ||
                    Resolution != null &&
                    Resolution.Equals(other.Resolution)
                ) && 
                (
                    SeriesType == other.SeriesType ||
                    SeriesType != null &&
                    SeriesType.Equals(other.SeriesType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (OriginalSize != null)
                    hashCode = hashCode * 59 + OriginalSize.GetHashCode();
                    if (Resolution != null)
                    hashCode = hashCode * 59 + Resolution.GetHashCode();
                    if (SeriesType != null)
                    hashCode = hashCode * 59 + SeriesType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BaseStream left, BaseStream right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BaseStream left, BaseStream right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
