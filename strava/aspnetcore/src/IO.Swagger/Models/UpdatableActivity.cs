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
    public partial class UpdatableActivity : IEquatable<UpdatableActivity>
    { 
        /// <summary>
        /// Whether this activity is a commute
        /// </summary>
        /// <value>Whether this activity is a commute</value>

        [DataMember(Name="commute")]
        public bool? Commute { get; set; }

        /// <summary>
        /// Whether this activity was recorded on a training machine
        /// </summary>
        /// <value>Whether this activity was recorded on a training machine</value>

        [DataMember(Name="trainer")]
        public bool? Trainer { get; set; }

        /// <summary>
        /// Whether this activity is muted
        /// </summary>
        /// <value>Whether this activity is muted</value>

        [DataMember(Name="hide_from_home")]
        public bool? HideFromHome { get; set; }

        /// <summary>
        /// The description of the activity
        /// </summary>
        /// <value>The description of the activity</value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// The name of the activity
        /// </summary>
        /// <value>The name of the activity</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name="type")]
        public ActivityType Type { get; set; }

        /// <summary>
        /// Identifier for the gear associated with the activity. ‘none’ clears gear from activity
        /// </summary>
        /// <value>Identifier for the gear associated with the activity. ‘none’ clears gear from activity</value>

        [DataMember(Name="gear_id")]
        public string GearId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatableActivity {\n");
            sb.Append("  Commute: ").Append(Commute).Append("\n");
            sb.Append("  Trainer: ").Append(Trainer).Append("\n");
            sb.Append("  HideFromHome: ").Append(HideFromHome).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  GearId: ").Append(GearId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UpdatableActivity)obj);
        }

        /// <summary>
        /// Returns true if UpdatableActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdatableActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatableActivity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Commute == other.Commute ||
                    Commute != null &&
                    Commute.Equals(other.Commute)
                ) && 
                (
                    Trainer == other.Trainer ||
                    Trainer != null &&
                    Trainer.Equals(other.Trainer)
                ) && 
                (
                    HideFromHome == other.HideFromHome ||
                    HideFromHome != null &&
                    HideFromHome.Equals(other.HideFromHome)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
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
                    GearId == other.GearId ||
                    GearId != null &&
                    GearId.Equals(other.GearId)
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
                    if (Commute != null)
                    hashCode = hashCode * 59 + Commute.GetHashCode();
                    if (Trainer != null)
                    hashCode = hashCode * 59 + Trainer.GetHashCode();
                    if (HideFromHome != null)
                    hashCode = hashCode * 59 + HideFromHome.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (GearId != null)
                    hashCode = hashCode * 59 + GearId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UpdatableActivity left, UpdatableActivity right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdatableActivity left, UpdatableActivity right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
