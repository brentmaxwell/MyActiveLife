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
    public partial class Comment : IEquatable<Comment>
    { 
        /// <summary>
        /// The unique identifier of this comment
        /// </summary>
        /// <value>The unique identifier of this comment</value>

        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// The identifier of the activity this comment is related to
        /// </summary>
        /// <value>The identifier of the activity this comment is related to</value>

        [DataMember(Name="activity_id")]
        public long? ActivityId { get; set; }

        /// <summary>
        /// The content of the comment
        /// </summary>
        /// <value>The content of the comment</value>

        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Athlete
        /// </summary>

        [DataMember(Name="athlete")]
        public SummaryAthlete Athlete { get; set; }

        /// <summary>
        /// The time at which this comment was created.
        /// </summary>
        /// <value>The time at which this comment was created.</value>

        [DataMember(Name="created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Comment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Athlete: ").Append(Athlete).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Comment)obj);
        }

        /// <summary>
        /// Returns true if Comment instances are equal
        /// </summary>
        /// <param name="other">Instance of Comment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Comment other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    ActivityId == other.ActivityId ||
                    ActivityId != null &&
                    ActivityId.Equals(other.ActivityId)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    Athlete == other.Athlete ||
                    Athlete != null &&
                    Athlete.Equals(other.Athlete)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (ActivityId != null)
                    hashCode = hashCode * 59 + ActivityId.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (Athlete != null)
                    hashCode = hashCode * 59 + Athlete.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Comment left, Comment right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Comment left, Comment right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
