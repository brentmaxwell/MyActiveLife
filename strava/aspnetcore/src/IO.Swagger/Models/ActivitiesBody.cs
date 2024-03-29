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
    public partial class ActivitiesBody : IEquatable<ActivitiesBody>
    { 
        /// <summary>
        /// The name of the activity.
        /// </summary>
        /// <value>The name of the activity.</value>
        [Required]

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Type of activity. For example - Run, Ride etc.
        /// </summary>
        /// <value>Type of activity. For example - Run, Ride etc.</value>
        [Required]

        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// ISO 8601 formatted date time.
        /// </summary>
        /// <value>ISO 8601 formatted date time.</value>
        [Required]

        [DataMember(Name="start_date_local")]
        public DateTime? StartDateLocal { get; set; }

        /// <summary>
        /// In seconds.
        /// </summary>
        /// <value>In seconds.</value>
        [Required]

        [DataMember(Name="elapsed_time")]
        public int? ElapsedTime { get; set; }

        /// <summary>
        /// Description of the activity.
        /// </summary>
        /// <value>Description of the activity.</value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// In meters.
        /// </summary>
        /// <value>In meters.</value>

        [DataMember(Name="distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// Set to 1 to mark as a trainer activity.
        /// </summary>
        /// <value>Set to 1 to mark as a trainer activity.</value>

        [DataMember(Name="trainer")]
        public int? Trainer { get; set; }

        /// <summary>
        /// Set to 1 to mark as commute.
        /// </summary>
        /// <value>Set to 1 to mark as commute.</value>

        [DataMember(Name="commute")]
        public int? Commute { get; set; }

        /// <summary>
        /// Set to true to mute activity.
        /// </summary>
        /// <value>Set to true to mute activity.</value>

        [DataMember(Name="hide_from_home")]
        public bool? HideFromHome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivitiesBody {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartDateLocal: ").Append(StartDateLocal).Append("\n");
            sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Trainer: ").Append(Trainer).Append("\n");
            sb.Append("  Commute: ").Append(Commute).Append("\n");
            sb.Append("  HideFromHome: ").Append(HideFromHome).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ActivitiesBody)obj);
        }

        /// <summary>
        /// Returns true if ActivitiesBody instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivitiesBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivitiesBody other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    StartDateLocal == other.StartDateLocal ||
                    StartDateLocal != null &&
                    StartDateLocal.Equals(other.StartDateLocal)
                ) && 
                (
                    ElapsedTime == other.ElapsedTime ||
                    ElapsedTime != null &&
                    ElapsedTime.Equals(other.ElapsedTime)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Distance == other.Distance ||
                    Distance != null &&
                    Distance.Equals(other.Distance)
                ) && 
                (
                    Trainer == other.Trainer ||
                    Trainer != null &&
                    Trainer.Equals(other.Trainer)
                ) && 
                (
                    Commute == other.Commute ||
                    Commute != null &&
                    Commute.Equals(other.Commute)
                ) && 
                (
                    HideFromHome == other.HideFromHome ||
                    HideFromHome != null &&
                    HideFromHome.Equals(other.HideFromHome)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (StartDateLocal != null)
                    hashCode = hashCode * 59 + StartDateLocal.GetHashCode();
                    if (ElapsedTime != null)
                    hashCode = hashCode * 59 + ElapsedTime.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Distance != null)
                    hashCode = hashCode * 59 + Distance.GetHashCode();
                    if (Trainer != null)
                    hashCode = hashCode * 59 + Trainer.GetHashCode();
                    if (Commute != null)
                    hashCode = hashCode * 59 + Commute.GetHashCode();
                    if (HideFromHome != null)
                    hashCode = hashCode * 59 + HideFromHome.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ActivitiesBody left, ActivitiesBody right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ActivitiesBody left, ActivitiesBody right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
