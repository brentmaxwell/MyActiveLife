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
    public partial class DetailedSegment : SummarySegment, IEquatable<DetailedSegment>
    { 
        /// <summary>
        /// The time at which the segment was created.
        /// </summary>
        /// <value>The time at which the segment was created.</value>

        [DataMember(Name="created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time at which the segment was last updated.
        /// </summary>
        /// <value>The time at which the segment was last updated.</value>

        [DataMember(Name="updated_at")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The segment&#x27;s total elevation gain.
        /// </summary>
        /// <value>The segment&#x27;s total elevation gain.</value>

        [DataMember(Name="total_elevation_gain")]
        public float? TotalElevationGain { get; set; }

        /// <summary>
        /// Gets or Sets Map
        /// </summary>

        [DataMember(Name="map")]
        public PolylineMap Map { get; set; }

        /// <summary>
        /// The total number of efforts for this segment
        /// </summary>
        /// <value>The total number of efforts for this segment</value>

        [DataMember(Name="effort_count")]
        public int? EffortCount { get; set; }

        /// <summary>
        /// The number of unique athletes who have an effort for this segment
        /// </summary>
        /// <value>The number of unique athletes who have an effort for this segment</value>

        [DataMember(Name="athlete_count")]
        public int? AthleteCount { get; set; }

        /// <summary>
        /// Whether this segment is considered hazardous
        /// </summary>
        /// <value>Whether this segment is considered hazardous</value>

        [DataMember(Name="hazardous")]
        public bool? Hazardous { get; set; }

        /// <summary>
        /// The number of stars for this segment
        /// </summary>
        /// <value>The number of stars for this segment</value>

        [DataMember(Name="star_count")]
        public int? StarCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedSegment {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  TotalElevationGain: ").Append(TotalElevationGain).Append("\n");
            sb.Append("  Map: ").Append(Map).Append("\n");
            sb.Append("  EffortCount: ").Append(EffortCount).Append("\n");
            sb.Append("  AthleteCount: ").Append(AthleteCount).Append("\n");
            sb.Append("  Hazardous: ").Append(Hazardous).Append("\n");
            sb.Append("  StarCount: ").Append(StarCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return obj.GetType() == GetType() && Equals((DetailedSegment)obj);
        }

        /// <summary>
        /// Returns true if DetailedSegment instances are equal
        /// </summary>
        /// <param name="other">Instance of DetailedSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedSegment other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    UpdatedAt == other.UpdatedAt ||
                    UpdatedAt != null &&
                    UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    TotalElevationGain == other.TotalElevationGain ||
                    TotalElevationGain != null &&
                    TotalElevationGain.Equals(other.TotalElevationGain)
                ) && 
                (
                    Map == other.Map ||
                    Map != null &&
                    Map.Equals(other.Map)
                ) && 
                (
                    EffortCount == other.EffortCount ||
                    EffortCount != null &&
                    EffortCount.Equals(other.EffortCount)
                ) && 
                (
                    AthleteCount == other.AthleteCount ||
                    AthleteCount != null &&
                    AthleteCount.Equals(other.AthleteCount)
                ) && 
                (
                    Hazardous == other.Hazardous ||
                    Hazardous != null &&
                    Hazardous.Equals(other.Hazardous)
                ) && 
                (
                    StarCount == other.StarCount ||
                    StarCount != null &&
                    StarCount.Equals(other.StarCount)
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
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                    if (UpdatedAt != null)
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                    if (TotalElevationGain != null)
                    hashCode = hashCode * 59 + TotalElevationGain.GetHashCode();
                    if (Map != null)
                    hashCode = hashCode * 59 + Map.GetHashCode();
                    if (EffortCount != null)
                    hashCode = hashCode * 59 + EffortCount.GetHashCode();
                    if (AthleteCount != null)
                    hashCode = hashCode * 59 + AthleteCount.GetHashCode();
                    if (Hazardous != null)
                    hashCode = hashCode * 59 + Hazardous.GetHashCode();
                    if (StarCount != null)
                    hashCode = hashCode * 59 + StarCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DetailedSegment left, DetailedSegment right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DetailedSegment left, DetailedSegment right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
