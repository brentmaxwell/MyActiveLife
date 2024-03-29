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
    public partial class StreamSet : IEquatable<StreamSet>
    { 
        /// <summary>
        /// Gets or Sets Time
        /// </summary>

        [DataMember(Name="time")]
        public TimeStream Time { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>

        [DataMember(Name="distance")]
        public DistanceStream Distance { get; set; }

        /// <summary>
        /// Gets or Sets Latlng
        /// </summary>

        [DataMember(Name="latlng")]
        public LatLngStream Latlng { get; set; }

        /// <summary>
        /// Gets or Sets Altitude
        /// </summary>

        [DataMember(Name="altitude")]
        public AltitudeStream Altitude { get; set; }

        /// <summary>
        /// Gets or Sets VelocitySmooth
        /// </summary>

        [DataMember(Name="velocity_smooth")]
        public SmoothVelocityStream VelocitySmooth { get; set; }

        /// <summary>
        /// Gets or Sets Heartrate
        /// </summary>

        [DataMember(Name="heartrate")]
        public HeartrateStream Heartrate { get; set; }

        /// <summary>
        /// Gets or Sets Cadence
        /// </summary>

        [DataMember(Name="cadence")]
        public CadenceStream Cadence { get; set; }

        /// <summary>
        /// Gets or Sets Watts
        /// </summary>

        [DataMember(Name="watts")]
        public PowerStream Watts { get; set; }

        /// <summary>
        /// Gets or Sets Temp
        /// </summary>

        [DataMember(Name="temp")]
        public TemperatureStream Temp { get; set; }

        /// <summary>
        /// Gets or Sets Moving
        /// </summary>

        [DataMember(Name="moving")]
        public MovingStream Moving { get; set; }

        /// <summary>
        /// Gets or Sets GradeSmooth
        /// </summary>

        [DataMember(Name="grade_smooth")]
        public SmoothGradeStream GradeSmooth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamSet {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Latlng: ").Append(Latlng).Append("\n");
            sb.Append("  Altitude: ").Append(Altitude).Append("\n");
            sb.Append("  VelocitySmooth: ").Append(VelocitySmooth).Append("\n");
            sb.Append("  Heartrate: ").Append(Heartrate).Append("\n");
            sb.Append("  Cadence: ").Append(Cadence).Append("\n");
            sb.Append("  Watts: ").Append(Watts).Append("\n");
            sb.Append("  Temp: ").Append(Temp).Append("\n");
            sb.Append("  Moving: ").Append(Moving).Append("\n");
            sb.Append("  GradeSmooth: ").Append(GradeSmooth).Append("\n");
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
            return obj.GetType() == GetType() && Equals((StreamSet)obj);
        }

        /// <summary>
        /// Returns true if StreamSet instances are equal
        /// </summary>
        /// <param name="other">Instance of StreamSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StreamSet other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Time == other.Time ||
                    Time != null &&
                    Time.Equals(other.Time)
                ) && 
                (
                    Distance == other.Distance ||
                    Distance != null &&
                    Distance.Equals(other.Distance)
                ) && 
                (
                    Latlng == other.Latlng ||
                    Latlng != null &&
                    Latlng.Equals(other.Latlng)
                ) && 
                (
                    Altitude == other.Altitude ||
                    Altitude != null &&
                    Altitude.Equals(other.Altitude)
                ) && 
                (
                    VelocitySmooth == other.VelocitySmooth ||
                    VelocitySmooth != null &&
                    VelocitySmooth.Equals(other.VelocitySmooth)
                ) && 
                (
                    Heartrate == other.Heartrate ||
                    Heartrate != null &&
                    Heartrate.Equals(other.Heartrate)
                ) && 
                (
                    Cadence == other.Cadence ||
                    Cadence != null &&
                    Cadence.Equals(other.Cadence)
                ) && 
                (
                    Watts == other.Watts ||
                    Watts != null &&
                    Watts.Equals(other.Watts)
                ) && 
                (
                    Temp == other.Temp ||
                    Temp != null &&
                    Temp.Equals(other.Temp)
                ) && 
                (
                    Moving == other.Moving ||
                    Moving != null &&
                    Moving.Equals(other.Moving)
                ) && 
                (
                    GradeSmooth == other.GradeSmooth ||
                    GradeSmooth != null &&
                    GradeSmooth.Equals(other.GradeSmooth)
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
                    if (Time != null)
                    hashCode = hashCode * 59 + Time.GetHashCode();
                    if (Distance != null)
                    hashCode = hashCode * 59 + Distance.GetHashCode();
                    if (Latlng != null)
                    hashCode = hashCode * 59 + Latlng.GetHashCode();
                    if (Altitude != null)
                    hashCode = hashCode * 59 + Altitude.GetHashCode();
                    if (VelocitySmooth != null)
                    hashCode = hashCode * 59 + VelocitySmooth.GetHashCode();
                    if (Heartrate != null)
                    hashCode = hashCode * 59 + Heartrate.GetHashCode();
                    if (Cadence != null)
                    hashCode = hashCode * 59 + Cadence.GetHashCode();
                    if (Watts != null)
                    hashCode = hashCode * 59 + Watts.GetHashCode();
                    if (Temp != null)
                    hashCode = hashCode * 59 + Temp.GetHashCode();
                    if (Moving != null)
                    hashCode = hashCode * 59 + Moving.GetHashCode();
                    if (GradeSmooth != null)
                    hashCode = hashCode * 59 + GradeSmooth.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(StreamSet left, StreamSet right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StreamSet left, StreamSet right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
