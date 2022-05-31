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
    public partial class ActivityZone : IEquatable<ActivityZone>
    { 
        /// <summary>
        /// Gets or Sets Score
        /// </summary>

        [DataMember(Name="score")]
        public int? Score { get; set; }

        /// <summary>
        /// Gets or Sets DistributionBuckets
        /// </summary>

        [DataMember(Name="distribution_buckets")]
        public TimedZoneDistribution DistributionBuckets { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum HeartrateEnum for heartrate
            /// </summary>
            [EnumMember(Value = "heartrate")]
            HeartrateEnum = 0,
            /// <summary>
            /// Enum PowerEnum for power
            /// </summary>
            [EnumMember(Value = "power")]
            PowerEnum = 1        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or Sets SensorBased
        /// </summary>

        [DataMember(Name="sensor_based")]
        public bool? SensorBased { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>

        [DataMember(Name="points")]
        public int? Points { get; set; }

        /// <summary>
        /// Gets or Sets CustomZones
        /// </summary>

        [DataMember(Name="custom_zones")]
        public bool? CustomZones { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>

        [DataMember(Name="max")]
        public int? Max { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityZone {\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  DistributionBuckets: ").Append(DistributionBuckets).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SensorBased: ").Append(SensorBased).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  CustomZones: ").Append(CustomZones).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ActivityZone)obj);
        }

        /// <summary>
        /// Returns true if ActivityZone instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityZone other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Score == other.Score ||
                    Score != null &&
                    Score.Equals(other.Score)
                ) && 
                (
                    DistributionBuckets == other.DistributionBuckets ||
                    DistributionBuckets != null &&
                    DistributionBuckets.Equals(other.DistributionBuckets)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    SensorBased == other.SensorBased ||
                    SensorBased != null &&
                    SensorBased.Equals(other.SensorBased)
                ) && 
                (
                    Points == other.Points ||
                    Points != null &&
                    Points.Equals(other.Points)
                ) && 
                (
                    CustomZones == other.CustomZones ||
                    CustomZones != null &&
                    CustomZones.Equals(other.CustomZones)
                ) && 
                (
                    Max == other.Max ||
                    Max != null &&
                    Max.Equals(other.Max)
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
                    if (Score != null)
                    hashCode = hashCode * 59 + Score.GetHashCode();
                    if (DistributionBuckets != null)
                    hashCode = hashCode * 59 + DistributionBuckets.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (SensorBased != null)
                    hashCode = hashCode * 59 + SensorBased.GetHashCode();
                    if (Points != null)
                    hashCode = hashCode * 59 + Points.GetHashCode();
                    if (CustomZones != null)
                    hashCode = hashCode * 59 + CustomZones.GetHashCode();
                    if (Max != null)
                    hashCode = hashCode * 59 + Max.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ActivityZone left, ActivityZone right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ActivityZone left, ActivityZone right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
