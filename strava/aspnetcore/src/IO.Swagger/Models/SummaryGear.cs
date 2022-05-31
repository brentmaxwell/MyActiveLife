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
    public partial class SummaryGear : IEquatable<SummaryGear>
    { 
        /// <summary>
        /// The gear&#x27;s unique identifier.
        /// </summary>
        /// <value>The gear&#x27;s unique identifier.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Resource state, indicates level of detail. Possible values: 2 -&gt; \&quot;summary\&quot;, 3 -&gt; \&quot;detail\&quot;
        /// </summary>
        /// <value>Resource state, indicates level of detail. Possible values: 2 -&gt; \&quot;summary\&quot;, 3 -&gt; \&quot;detail\&quot;</value>

        [DataMember(Name="resource_state")]
        public int? ResourceState { get; set; }

        /// <summary>
        /// Whether this gear&#x27;s is the owner&#x27;s default one.
        /// </summary>
        /// <value>Whether this gear&#x27;s is the owner&#x27;s default one.</value>

        [DataMember(Name="primary")]
        public bool? Primary { get; set; }

        /// <summary>
        /// The gear&#x27;s name.
        /// </summary>
        /// <value>The gear&#x27;s name.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The distance logged with this gear.
        /// </summary>
        /// <value>The distance logged with this gear.</value>

        [DataMember(Name="distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummaryGear {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ResourceState: ").Append(ResourceState).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SummaryGear)obj);
        }

        /// <summary>
        /// Returns true if SummaryGear instances are equal
        /// </summary>
        /// <param name="other">Instance of SummaryGear to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummaryGear other)
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
                    ResourceState == other.ResourceState ||
                    ResourceState != null &&
                    ResourceState.Equals(other.ResourceState)
                ) && 
                (
                    Primary == other.Primary ||
                    Primary != null &&
                    Primary.Equals(other.Primary)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Distance == other.Distance ||
                    Distance != null &&
                    Distance.Equals(other.Distance)
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
                    if (ResourceState != null)
                    hashCode = hashCode * 59 + ResourceState.GetHashCode();
                    if (Primary != null)
                    hashCode = hashCode * 59 + Primary.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Distance != null)
                    hashCode = hashCode * 59 + Distance.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SummaryGear left, SummaryGear right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SummaryGear left, SummaryGear right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
