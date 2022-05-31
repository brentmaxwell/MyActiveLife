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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// DetailedSegmentEffort
    /// </summary>
    [DataContract]
        public partial class DetailedSegmentEffort : SummarySegmentEffort,  IEquatable<DetailedSegmentEffort>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedSegmentEffort" /> class.
        /// </summary>
        /// <param name="name">The name of the segment on which this effort was performed.</param>
        /// <param name="activity">activity.</param>
        /// <param name="athlete">athlete.</param>
        /// <param name="movingTime">The effort&#x27;s moving time.</param>
        /// <param name="startIndex">The start index of this effort in its activity&#x27;s stream.</param>
        /// <param name="endIndex">The end index of this effort in its activity&#x27;s stream.</param>
        /// <param name="averageCadence">The effort&#x27;s average cadence.</param>
        /// <param name="averageWatts">The average wattage of this effort.</param>
        /// <param name="deviceWatts">For riding efforts, whether the wattage was reported by a dedicated recording device.</param>
        /// <param name="averageHeartrate">The heart heart rate of the athlete during this effort.</param>
        /// <param name="maxHeartrate">The maximum heart rate of the athlete during this effort.</param>
        /// <param name="segment">segment.</param>
        /// <param name="komRank">The rank of the effort on the global leaderboard if it belongs in the top 10 at the time of upload.</param>
        /// <param name="prRank">The rank of the effort on the athlete&#x27;s leaderboard if it belongs in the top 3 at the time of upload.</param>
        /// <param name="hidden">Whether this effort should be hidden when viewed within an activity.</param>
        public DetailedSegmentEffort(string name = default(string), MetaActivity activity = default(MetaActivity), MetaAthlete athlete = default(MetaAthlete), int? movingTime = default(int?), int? startIndex = default(int?), int? endIndex = default(int?), float? averageCadence = default(float?), float? averageWatts = default(float?), bool? deviceWatts = default(bool?), float? averageHeartrate = default(float?), float? maxHeartrate = default(float?), SummarySegment segment = default(SummarySegment), int? komRank = default(int?), int? prRank = default(int?), bool? hidden = default(bool?), long? id = default(long?), long? activityId = default(long?), int? elapsedTime = default(int?), DateTime? startDate = default(DateTime?), DateTime? startDateLocal = default(DateTime?), float? distance = default(float?), bool? isKom = default(bool?)) : base(id, activityId, elapsedTime, startDate, startDateLocal, distance, isKom)
        {
            this.Name = name;
            this.Activity = activity;
            this.Athlete = athlete;
            this.MovingTime = movingTime;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.AverageCadence = averageCadence;
            this.AverageWatts = averageWatts;
            this.DeviceWatts = deviceWatts;
            this.AverageHeartrate = averageHeartrate;
            this.MaxHeartrate = maxHeartrate;
            this.Segment = segment;
            this.KomRank = komRank;
            this.PrRank = prRank;
            this.Hidden = hidden;
        }
        
        /// <summary>
        /// The name of the segment on which this effort was performed
        /// </summary>
        /// <value>The name of the segment on which this effort was performed</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Activity
        /// </summary>
        [DataMember(Name="activity", EmitDefaultValue=false)]
        public MetaActivity Activity { get; set; }

        /// <summary>
        /// Gets or Sets Athlete
        /// </summary>
        [DataMember(Name="athlete", EmitDefaultValue=false)]
        public MetaAthlete Athlete { get; set; }

        /// <summary>
        /// The effort&#x27;s moving time
        /// </summary>
        /// <value>The effort&#x27;s moving time</value>
        [DataMember(Name="moving_time", EmitDefaultValue=false)]
        public int? MovingTime { get; set; }

        /// <summary>
        /// The start index of this effort in its activity&#x27;s stream
        /// </summary>
        /// <value>The start index of this effort in its activity&#x27;s stream</value>
        [DataMember(Name="start_index", EmitDefaultValue=false)]
        public int? StartIndex { get; set; }

        /// <summary>
        /// The end index of this effort in its activity&#x27;s stream
        /// </summary>
        /// <value>The end index of this effort in its activity&#x27;s stream</value>
        [DataMember(Name="end_index", EmitDefaultValue=false)]
        public int? EndIndex { get; set; }

        /// <summary>
        /// The effort&#x27;s average cadence
        /// </summary>
        /// <value>The effort&#x27;s average cadence</value>
        [DataMember(Name="average_cadence", EmitDefaultValue=false)]
        public float? AverageCadence { get; set; }

        /// <summary>
        /// The average wattage of this effort
        /// </summary>
        /// <value>The average wattage of this effort</value>
        [DataMember(Name="average_watts", EmitDefaultValue=false)]
        public float? AverageWatts { get; set; }

        /// <summary>
        /// For riding efforts, whether the wattage was reported by a dedicated recording device
        /// </summary>
        /// <value>For riding efforts, whether the wattage was reported by a dedicated recording device</value>
        [DataMember(Name="device_watts", EmitDefaultValue=false)]
        public bool? DeviceWatts { get; set; }

        /// <summary>
        /// The heart heart rate of the athlete during this effort
        /// </summary>
        /// <value>The heart heart rate of the athlete during this effort</value>
        [DataMember(Name="average_heartrate", EmitDefaultValue=false)]
        public float? AverageHeartrate { get; set; }

        /// <summary>
        /// The maximum heart rate of the athlete during this effort
        /// </summary>
        /// <value>The maximum heart rate of the athlete during this effort</value>
        [DataMember(Name="max_heartrate", EmitDefaultValue=false)]
        public float? MaxHeartrate { get; set; }

        /// <summary>
        /// Gets or Sets Segment
        /// </summary>
        [DataMember(Name="segment", EmitDefaultValue=false)]
        public SummarySegment Segment { get; set; }

        /// <summary>
        /// The rank of the effort on the global leaderboard if it belongs in the top 10 at the time of upload
        /// </summary>
        /// <value>The rank of the effort on the global leaderboard if it belongs in the top 10 at the time of upload</value>
        [DataMember(Name="kom_rank", EmitDefaultValue=false)]
        public int? KomRank { get; set; }

        /// <summary>
        /// The rank of the effort on the athlete&#x27;s leaderboard if it belongs in the top 3 at the time of upload
        /// </summary>
        /// <value>The rank of the effort on the athlete&#x27;s leaderboard if it belongs in the top 3 at the time of upload</value>
        [DataMember(Name="pr_rank", EmitDefaultValue=false)]
        public int? PrRank { get; set; }

        /// <summary>
        /// Whether this effort should be hidden when viewed within an activity
        /// </summary>
        /// <value>Whether this effort should be hidden when viewed within an activity</value>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedSegmentEffort {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
            sb.Append("  Athlete: ").Append(Athlete).Append("\n");
            sb.Append("  MovingTime: ").Append(MovingTime).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  EndIndex: ").Append(EndIndex).Append("\n");
            sb.Append("  AverageCadence: ").Append(AverageCadence).Append("\n");
            sb.Append("  AverageWatts: ").Append(AverageWatts).Append("\n");
            sb.Append("  DeviceWatts: ").Append(DeviceWatts).Append("\n");
            sb.Append("  AverageHeartrate: ").Append(AverageHeartrate).Append("\n");
            sb.Append("  MaxHeartrate: ").Append(MaxHeartrate).Append("\n");
            sb.Append("  Segment: ").Append(Segment).Append("\n");
            sb.Append("  KomRank: ").Append(KomRank).Append("\n");
            sb.Append("  PrRank: ").Append(PrRank).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetailedSegmentEffort);
        }

        /// <summary>
        /// Returns true if DetailedSegmentEffort instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedSegmentEffort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedSegmentEffort input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Activity == input.Activity ||
                    (this.Activity != null &&
                    this.Activity.Equals(input.Activity))
                ) && base.Equals(input) && 
                (
                    this.Athlete == input.Athlete ||
                    (this.Athlete != null &&
                    this.Athlete.Equals(input.Athlete))
                ) && base.Equals(input) && 
                (
                    this.MovingTime == input.MovingTime ||
                    (this.MovingTime != null &&
                    this.MovingTime.Equals(input.MovingTime))
                ) && base.Equals(input) && 
                (
                    this.StartIndex == input.StartIndex ||
                    (this.StartIndex != null &&
                    this.StartIndex.Equals(input.StartIndex))
                ) && base.Equals(input) && 
                (
                    this.EndIndex == input.EndIndex ||
                    (this.EndIndex != null &&
                    this.EndIndex.Equals(input.EndIndex))
                ) && base.Equals(input) && 
                (
                    this.AverageCadence == input.AverageCadence ||
                    (this.AverageCadence != null &&
                    this.AverageCadence.Equals(input.AverageCadence))
                ) && base.Equals(input) && 
                (
                    this.AverageWatts == input.AverageWatts ||
                    (this.AverageWatts != null &&
                    this.AverageWatts.Equals(input.AverageWatts))
                ) && base.Equals(input) && 
                (
                    this.DeviceWatts == input.DeviceWatts ||
                    (this.DeviceWatts != null &&
                    this.DeviceWatts.Equals(input.DeviceWatts))
                ) && base.Equals(input) && 
                (
                    this.AverageHeartrate == input.AverageHeartrate ||
                    (this.AverageHeartrate != null &&
                    this.AverageHeartrate.Equals(input.AverageHeartrate))
                ) && base.Equals(input) && 
                (
                    this.MaxHeartrate == input.MaxHeartrate ||
                    (this.MaxHeartrate != null &&
                    this.MaxHeartrate.Equals(input.MaxHeartrate))
                ) && base.Equals(input) && 
                (
                    this.Segment == input.Segment ||
                    (this.Segment != null &&
                    this.Segment.Equals(input.Segment))
                ) && base.Equals(input) && 
                (
                    this.KomRank == input.KomRank ||
                    (this.KomRank != null &&
                    this.KomRank.Equals(input.KomRank))
                ) && base.Equals(input) && 
                (
                    this.PrRank == input.PrRank ||
                    (this.PrRank != null &&
                    this.PrRank.Equals(input.PrRank))
                ) && base.Equals(input) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
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
                int hashCode = base.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Activity != null)
                    hashCode = hashCode * 59 + this.Activity.GetHashCode();
                if (this.Athlete != null)
                    hashCode = hashCode * 59 + this.Athlete.GetHashCode();
                if (this.MovingTime != null)
                    hashCode = hashCode * 59 + this.MovingTime.GetHashCode();
                if (this.StartIndex != null)
                    hashCode = hashCode * 59 + this.StartIndex.GetHashCode();
                if (this.EndIndex != null)
                    hashCode = hashCode * 59 + this.EndIndex.GetHashCode();
                if (this.AverageCadence != null)
                    hashCode = hashCode * 59 + this.AverageCadence.GetHashCode();
                if (this.AverageWatts != null)
                    hashCode = hashCode * 59 + this.AverageWatts.GetHashCode();
                if (this.DeviceWatts != null)
                    hashCode = hashCode * 59 + this.DeviceWatts.GetHashCode();
                if (this.AverageHeartrate != null)
                    hashCode = hashCode * 59 + this.AverageHeartrate.GetHashCode();
                if (this.MaxHeartrate != null)
                    hashCode = hashCode * 59 + this.MaxHeartrate.GetHashCode();
                if (this.Segment != null)
                    hashCode = hashCode * 59 + this.Segment.GetHashCode();
                if (this.KomRank != null)
                    hashCode = hashCode * 59 + this.KomRank.GetHashCode();
                if (this.PrRank != null)
                    hashCode = hashCode * 59 + this.PrRank.GetHashCode();
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
