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
    public partial class PhotosSummary : IEquatable<PhotosSummary>
    { 
        /// <summary>
        /// The number of photos
        /// </summary>
        /// <value>The number of photos</value>

        [DataMember(Name="count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets Primary
        /// </summary>

        [DataMember(Name="primary")]
        public PhotosSummaryPrimary Primary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhotosSummary {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PhotosSummary)obj);
        }

        /// <summary>
        /// Returns true if PhotosSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of PhotosSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhotosSummary other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Count == other.Count ||
                    Count != null &&
                    Count.Equals(other.Count)
                ) && 
                (
                    Primary == other.Primary ||
                    Primary != null &&
                    Primary.Equals(other.Primary)
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
                    if (Count != null)
                    hashCode = hashCode * 59 + Count.GetHashCode();
                    if (Primary != null)
                    hashCode = hashCode * 59 + Primary.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PhotosSummary left, PhotosSummary right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PhotosSummary left, PhotosSummary right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
