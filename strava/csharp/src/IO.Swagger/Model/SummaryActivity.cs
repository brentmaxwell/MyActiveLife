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
    /// SummaryActivity
    /// </summary>
    [DataContract]
        public partial class SummaryActivity : MetaActivity,  IEquatable<SummaryActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryActivity" /> class.
        /// </summary>
        /// <param name="externalId">The identifier provided at upload time.</param>
        /// <param name="uploadId">The identifier of the upload that resulted in this activity.</param>
        /// <param name="athlete">athlete.</param>
        /// <param name="name">The name of the activity.</param>
        /// <param name="distance">The activity&#x27;s distance, in meters.</param>
        /// <param name="movingTime">The activity&#x27;s moving time, in seconds.</param>
        /// <param name="elapsedTime">The activity&#x27;s elapsed time, in seconds.</param>
        /// <param name="totalElevationGain">The activity&#x27;s total elevation gain..</param>
        /// <param name="elevHigh">The activity&#x27;s highest elevation, in meters.</param>
        /// <param name="elevLow">The activity&#x27;s lowest elevation, in meters.</param>
        /// <param name="type">type.</param>
        /// <param name="startDate">The time at which the activity was started..</param>
        /// <param name="startDateLocal">The time at which the activity was started in the local timezone..</param>
        /// <param name="timezone">The timezone of the activity.</param>
        /// <param name="startLatlng">startLatlng.</param>
        /// <param name="endLatlng">endLatlng.</param>
        /// <param name="achievementCount">The number of achievements gained during this activity.</param>
        /// <param name="kudosCount">The number of kudos given for this activity.</param>
        /// <param name="commentCount">The number of comments for this activity.</param>
        /// <param name="athleteCount">The number of athletes for taking part in a group activity.</param>
        /// <param name="photoCount">The number of Instagram photos for this activity.</param>
        /// <param name="totalPhotoCount">The number of Instagram and Strava photos for this activity.</param>
        /// <param name="map">map.</param>
        /// <param name="trainer">Whether this activity was recorded on a training machine.</param>
        /// <param name="commute">Whether this activity is a commute.</param>
        /// <param name="manual">Whether this activity was created manually.</param>
        /// <param name="_private">Whether this activity is private.</param>
        /// <param name="flagged">Whether this activity is flagged.</param>
        /// <param name="workoutType">The activity&#x27;s workout type.</param>
        /// <param name="uploadIdStr">The unique identifier of the upload in string format.</param>
        /// <param name="averageSpeed">The activity&#x27;s average speed, in meters per second.</param>
        /// <param name="maxSpeed">The activity&#x27;s max speed, in meters per second.</param>
        /// <param name="hasKudoed">Whether the logged-in athlete has kudoed this activity.</param>
        /// <param name="hideFromHome">Whether the activity is muted.</param>
        /// <param name="gearId">The id of the gear for the activity.</param>
        /// <param name="kilojoules">The total work done in kilojoules during this activity. Rides only.</param>
        /// <param name="averageWatts">Average power output in watts during this activity. Rides only.</param>
        /// <param name="deviceWatts">Whether the watts are from a power meter, false if estimated.</param>
        /// <param name="maxWatts">Rides with power meter data only.</param>
        /// <param name="weightedAverageWatts">Similar to Normalized Power. Rides with power meter data only.</param>
        public SummaryActivity(string externalId = default(string), long? uploadId = default(long?), MetaAthlete athlete = default(MetaAthlete), string name = default(string), float? distance = default(float?), int? movingTime = default(int?), int? elapsedTime = default(int?), float? totalElevationGain = default(float?), float? elevHigh = default(float?), float? elevLow = default(float?), ActivityType type = default(ActivityType), DateTime? startDate = default(DateTime?), DateTime? startDateLocal = default(DateTime?), string timezone = default(string), LatLng startLatlng = default(LatLng), LatLng endLatlng = default(LatLng), int? achievementCount = default(int?), int? kudosCount = default(int?), int? commentCount = default(int?), int? athleteCount = default(int?), int? photoCount = default(int?), int? totalPhotoCount = default(int?), PolylineMap map = default(PolylineMap), bool? trainer = default(bool?), bool? commute = default(bool?), bool? manual = default(bool?), bool? _private = default(bool?), bool? flagged = default(bool?), int? workoutType = default(int?), string uploadIdStr = default(string), float? averageSpeed = default(float?), float? maxSpeed = default(float?), bool? hasKudoed = default(bool?), bool? hideFromHome = default(bool?), string gearId = default(string), float? kilojoules = default(float?), float? averageWatts = default(float?), bool? deviceWatts = default(bool?), int? maxWatts = default(int?), int? weightedAverageWatts = default(int?), long? id = default(long?)) : base(id)
        {
            this.ExternalId = externalId;
            this.UploadId = uploadId;
            this.Athlete = athlete;
            this.Name = name;
            this.Distance = distance;
            this.MovingTime = movingTime;
            this.ElapsedTime = elapsedTime;
            this.TotalElevationGain = totalElevationGain;
            this.ElevHigh = elevHigh;
            this.ElevLow = elevLow;
            this.Type = type;
            this.StartDate = startDate;
            this.StartDateLocal = startDateLocal;
            this.Timezone = timezone;
            this.StartLatlng = startLatlng;
            this.EndLatlng = endLatlng;
            this.AchievementCount = achievementCount;
            this.KudosCount = kudosCount;
            this.CommentCount = commentCount;
            this.AthleteCount = athleteCount;
            this.PhotoCount = photoCount;
            this.TotalPhotoCount = totalPhotoCount;
            this.Map = map;
            this.Trainer = trainer;
            this.Commute = commute;
            this.Manual = manual;
            this._Private = _private;
            this.Flagged = flagged;
            this.WorkoutType = workoutType;
            this.UploadIdStr = uploadIdStr;
            this.AverageSpeed = averageSpeed;
            this.MaxSpeed = maxSpeed;
            this.HasKudoed = hasKudoed;
            this.HideFromHome = hideFromHome;
            this.GearId = gearId;
            this.Kilojoules = kilojoules;
            this.AverageWatts = averageWatts;
            this.DeviceWatts = deviceWatts;
            this.MaxWatts = maxWatts;
            this.WeightedAverageWatts = weightedAverageWatts;
        }
        
        /// <summary>
        /// The identifier provided at upload time
        /// </summary>
        /// <value>The identifier provided at upload time</value>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The identifier of the upload that resulted in this activity
        /// </summary>
        /// <value>The identifier of the upload that resulted in this activity</value>
        [DataMember(Name="upload_id", EmitDefaultValue=false)]
        public long? UploadId { get; set; }

        /// <summary>
        /// Gets or Sets Athlete
        /// </summary>
        [DataMember(Name="athlete", EmitDefaultValue=false)]
        public MetaAthlete Athlete { get; set; }

        /// <summary>
        /// The name of the activity
        /// </summary>
        /// <value>The name of the activity</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The activity&#x27;s distance, in meters
        /// </summary>
        /// <value>The activity&#x27;s distance, in meters</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public float? Distance { get; set; }

        /// <summary>
        /// The activity&#x27;s moving time, in seconds
        /// </summary>
        /// <value>The activity&#x27;s moving time, in seconds</value>
        [DataMember(Name="moving_time", EmitDefaultValue=false)]
        public int? MovingTime { get; set; }

        /// <summary>
        /// The activity&#x27;s elapsed time, in seconds
        /// </summary>
        /// <value>The activity&#x27;s elapsed time, in seconds</value>
        [DataMember(Name="elapsed_time", EmitDefaultValue=false)]
        public int? ElapsedTime { get; set; }

        /// <summary>
        /// The activity&#x27;s total elevation gain.
        /// </summary>
        /// <value>The activity&#x27;s total elevation gain.</value>
        [DataMember(Name="total_elevation_gain", EmitDefaultValue=false)]
        public float? TotalElevationGain { get; set; }

        /// <summary>
        /// The activity&#x27;s highest elevation, in meters
        /// </summary>
        /// <value>The activity&#x27;s highest elevation, in meters</value>
        [DataMember(Name="elev_high", EmitDefaultValue=false)]
        public float? ElevHigh { get; set; }

        /// <summary>
        /// The activity&#x27;s lowest elevation, in meters
        /// </summary>
        /// <value>The activity&#x27;s lowest elevation, in meters</value>
        [DataMember(Name="elev_low", EmitDefaultValue=false)]
        public float? ElevLow { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public ActivityType Type { get; set; }

        /// <summary>
        /// The time at which the activity was started.
        /// </summary>
        /// <value>The time at which the activity was started.</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The time at which the activity was started in the local timezone.
        /// </summary>
        /// <value>The time at which the activity was started in the local timezone.</value>
        [DataMember(Name="start_date_local", EmitDefaultValue=false)]
        public DateTime? StartDateLocal { get; set; }

        /// <summary>
        /// The timezone of the activity
        /// </summary>
        /// <value>The timezone of the activity</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets StartLatlng
        /// </summary>
        [DataMember(Name="start_latlng", EmitDefaultValue=false)]
        public LatLng StartLatlng { get; set; }

        /// <summary>
        /// Gets or Sets EndLatlng
        /// </summary>
        [DataMember(Name="end_latlng", EmitDefaultValue=false)]
        public LatLng EndLatlng { get; set; }

        /// <summary>
        /// The number of achievements gained during this activity
        /// </summary>
        /// <value>The number of achievements gained during this activity</value>
        [DataMember(Name="achievement_count", EmitDefaultValue=false)]
        public int? AchievementCount { get; set; }

        /// <summary>
        /// The number of kudos given for this activity
        /// </summary>
        /// <value>The number of kudos given for this activity</value>
        [DataMember(Name="kudos_count", EmitDefaultValue=false)]
        public int? KudosCount { get; set; }

        /// <summary>
        /// The number of comments for this activity
        /// </summary>
        /// <value>The number of comments for this activity</value>
        [DataMember(Name="comment_count", EmitDefaultValue=false)]
        public int? CommentCount { get; set; }

        /// <summary>
        /// The number of athletes for taking part in a group activity
        /// </summary>
        /// <value>The number of athletes for taking part in a group activity</value>
        [DataMember(Name="athlete_count", EmitDefaultValue=false)]
        public int? AthleteCount { get; set; }

        /// <summary>
        /// The number of Instagram photos for this activity
        /// </summary>
        /// <value>The number of Instagram photos for this activity</value>
        [DataMember(Name="photo_count", EmitDefaultValue=false)]
        public int? PhotoCount { get; set; }

        /// <summary>
        /// The number of Instagram and Strava photos for this activity
        /// </summary>
        /// <value>The number of Instagram and Strava photos for this activity</value>
        [DataMember(Name="total_photo_count", EmitDefaultValue=false)]
        public int? TotalPhotoCount { get; set; }

        /// <summary>
        /// Gets or Sets Map
        /// </summary>
        [DataMember(Name="map", EmitDefaultValue=false)]
        public PolylineMap Map { get; set; }

        /// <summary>
        /// Whether this activity was recorded on a training machine
        /// </summary>
        /// <value>Whether this activity was recorded on a training machine</value>
        [DataMember(Name="trainer", EmitDefaultValue=false)]
        public bool? Trainer { get; set; }

        /// <summary>
        /// Whether this activity is a commute
        /// </summary>
        /// <value>Whether this activity is a commute</value>
        [DataMember(Name="commute", EmitDefaultValue=false)]
        public bool? Commute { get; set; }

        /// <summary>
        /// Whether this activity was created manually
        /// </summary>
        /// <value>Whether this activity was created manually</value>
        [DataMember(Name="manual", EmitDefaultValue=false)]
        public bool? Manual { get; set; }

        /// <summary>
        /// Whether this activity is private
        /// </summary>
        /// <value>Whether this activity is private</value>
        [DataMember(Name="private", EmitDefaultValue=false)]
        public bool? _Private { get; set; }

        /// <summary>
        /// Whether this activity is flagged
        /// </summary>
        /// <value>Whether this activity is flagged</value>
        [DataMember(Name="flagged", EmitDefaultValue=false)]
        public bool? Flagged { get; set; }

        /// <summary>
        /// The activity&#x27;s workout type
        /// </summary>
        /// <value>The activity&#x27;s workout type</value>
        [DataMember(Name="workout_type", EmitDefaultValue=false)]
        public int? WorkoutType { get; set; }

        /// <summary>
        /// The unique identifier of the upload in string format
        /// </summary>
        /// <value>The unique identifier of the upload in string format</value>
        [DataMember(Name="upload_id_str", EmitDefaultValue=false)]
        public string UploadIdStr { get; set; }

        /// <summary>
        /// The activity&#x27;s average speed, in meters per second
        /// </summary>
        /// <value>The activity&#x27;s average speed, in meters per second</value>
        [DataMember(Name="average_speed", EmitDefaultValue=false)]
        public float? AverageSpeed { get; set; }

        /// <summary>
        /// The activity&#x27;s max speed, in meters per second
        /// </summary>
        /// <value>The activity&#x27;s max speed, in meters per second</value>
        [DataMember(Name="max_speed", EmitDefaultValue=false)]
        public float? MaxSpeed { get; set; }

        /// <summary>
        /// Whether the logged-in athlete has kudoed this activity
        /// </summary>
        /// <value>Whether the logged-in athlete has kudoed this activity</value>
        [DataMember(Name="has_kudoed", EmitDefaultValue=false)]
        public bool? HasKudoed { get; set; }

        /// <summary>
        /// Whether the activity is muted
        /// </summary>
        /// <value>Whether the activity is muted</value>
        [DataMember(Name="hide_from_home", EmitDefaultValue=false)]
        public bool? HideFromHome { get; set; }

        /// <summary>
        /// The id of the gear for the activity
        /// </summary>
        /// <value>The id of the gear for the activity</value>
        [DataMember(Name="gear_id", EmitDefaultValue=false)]
        public string GearId { get; set; }

        /// <summary>
        /// The total work done in kilojoules during this activity. Rides only
        /// </summary>
        /// <value>The total work done in kilojoules during this activity. Rides only</value>
        [DataMember(Name="kilojoules", EmitDefaultValue=false)]
        public float? Kilojoules { get; set; }

        /// <summary>
        /// Average power output in watts during this activity. Rides only
        /// </summary>
        /// <value>Average power output in watts during this activity. Rides only</value>
        [DataMember(Name="average_watts", EmitDefaultValue=false)]
        public float? AverageWatts { get; set; }

        /// <summary>
        /// Whether the watts are from a power meter, false if estimated
        /// </summary>
        /// <value>Whether the watts are from a power meter, false if estimated</value>
        [DataMember(Name="device_watts", EmitDefaultValue=false)]
        public bool? DeviceWatts { get; set; }

        /// <summary>
        /// Rides with power meter data only
        /// </summary>
        /// <value>Rides with power meter data only</value>
        [DataMember(Name="max_watts", EmitDefaultValue=false)]
        public int? MaxWatts { get; set; }

        /// <summary>
        /// Similar to Normalized Power. Rides with power meter data only
        /// </summary>
        /// <value>Similar to Normalized Power. Rides with power meter data only</value>
        [DataMember(Name="weighted_average_watts", EmitDefaultValue=false)]
        public int? WeightedAverageWatts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummaryActivity {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  UploadId: ").Append(UploadId).Append("\n");
            sb.Append("  Athlete: ").Append(Athlete).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  MovingTime: ").Append(MovingTime).Append("\n");
            sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
            sb.Append("  TotalElevationGain: ").Append(TotalElevationGain).Append("\n");
            sb.Append("  ElevHigh: ").Append(ElevHigh).Append("\n");
            sb.Append("  ElevLow: ").Append(ElevLow).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  StartDateLocal: ").Append(StartDateLocal).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  StartLatlng: ").Append(StartLatlng).Append("\n");
            sb.Append("  EndLatlng: ").Append(EndLatlng).Append("\n");
            sb.Append("  AchievementCount: ").Append(AchievementCount).Append("\n");
            sb.Append("  KudosCount: ").Append(KudosCount).Append("\n");
            sb.Append("  CommentCount: ").Append(CommentCount).Append("\n");
            sb.Append("  AthleteCount: ").Append(AthleteCount).Append("\n");
            sb.Append("  PhotoCount: ").Append(PhotoCount).Append("\n");
            sb.Append("  TotalPhotoCount: ").Append(TotalPhotoCount).Append("\n");
            sb.Append("  Map: ").Append(Map).Append("\n");
            sb.Append("  Trainer: ").Append(Trainer).Append("\n");
            sb.Append("  Commute: ").Append(Commute).Append("\n");
            sb.Append("  Manual: ").Append(Manual).Append("\n");
            sb.Append("  _Private: ").Append(_Private).Append("\n");
            sb.Append("  Flagged: ").Append(Flagged).Append("\n");
            sb.Append("  WorkoutType: ").Append(WorkoutType).Append("\n");
            sb.Append("  UploadIdStr: ").Append(UploadIdStr).Append("\n");
            sb.Append("  AverageSpeed: ").Append(AverageSpeed).Append("\n");
            sb.Append("  MaxSpeed: ").Append(MaxSpeed).Append("\n");
            sb.Append("  HasKudoed: ").Append(HasKudoed).Append("\n");
            sb.Append("  HideFromHome: ").Append(HideFromHome).Append("\n");
            sb.Append("  GearId: ").Append(GearId).Append("\n");
            sb.Append("  Kilojoules: ").Append(Kilojoules).Append("\n");
            sb.Append("  AverageWatts: ").Append(AverageWatts).Append("\n");
            sb.Append("  DeviceWatts: ").Append(DeviceWatts).Append("\n");
            sb.Append("  MaxWatts: ").Append(MaxWatts).Append("\n");
            sb.Append("  WeightedAverageWatts: ").Append(WeightedAverageWatts).Append("\n");
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
            return this.Equals(input as SummaryActivity);
        }

        /// <summary>
        /// Returns true if SummaryActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of SummaryActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummaryActivity input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && base.Equals(input) && 
                (
                    this.UploadId == input.UploadId ||
                    (this.UploadId != null &&
                    this.UploadId.Equals(input.UploadId))
                ) && base.Equals(input) && 
                (
                    this.Athlete == input.Athlete ||
                    (this.Athlete != null &&
                    this.Athlete.Equals(input.Athlete))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && base.Equals(input) && 
                (
                    this.MovingTime == input.MovingTime ||
                    (this.MovingTime != null &&
                    this.MovingTime.Equals(input.MovingTime))
                ) && base.Equals(input) && 
                (
                    this.ElapsedTime == input.ElapsedTime ||
                    (this.ElapsedTime != null &&
                    this.ElapsedTime.Equals(input.ElapsedTime))
                ) && base.Equals(input) && 
                (
                    this.TotalElevationGain == input.TotalElevationGain ||
                    (this.TotalElevationGain != null &&
                    this.TotalElevationGain.Equals(input.TotalElevationGain))
                ) && base.Equals(input) && 
                (
                    this.ElevHigh == input.ElevHigh ||
                    (this.ElevHigh != null &&
                    this.ElevHigh.Equals(input.ElevHigh))
                ) && base.Equals(input) && 
                (
                    this.ElevLow == input.ElevLow ||
                    (this.ElevLow != null &&
                    this.ElevLow.Equals(input.ElevLow))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && base.Equals(input) && 
                (
                    this.StartDateLocal == input.StartDateLocal ||
                    (this.StartDateLocal != null &&
                    this.StartDateLocal.Equals(input.StartDateLocal))
                ) && base.Equals(input) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && base.Equals(input) && 
                (
                    this.StartLatlng == input.StartLatlng ||
                    (this.StartLatlng != null &&
                    this.StartLatlng.Equals(input.StartLatlng))
                ) && base.Equals(input) && 
                (
                    this.EndLatlng == input.EndLatlng ||
                    (this.EndLatlng != null &&
                    this.EndLatlng.Equals(input.EndLatlng))
                ) && base.Equals(input) && 
                (
                    this.AchievementCount == input.AchievementCount ||
                    (this.AchievementCount != null &&
                    this.AchievementCount.Equals(input.AchievementCount))
                ) && base.Equals(input) && 
                (
                    this.KudosCount == input.KudosCount ||
                    (this.KudosCount != null &&
                    this.KudosCount.Equals(input.KudosCount))
                ) && base.Equals(input) && 
                (
                    this.CommentCount == input.CommentCount ||
                    (this.CommentCount != null &&
                    this.CommentCount.Equals(input.CommentCount))
                ) && base.Equals(input) && 
                (
                    this.AthleteCount == input.AthleteCount ||
                    (this.AthleteCount != null &&
                    this.AthleteCount.Equals(input.AthleteCount))
                ) && base.Equals(input) && 
                (
                    this.PhotoCount == input.PhotoCount ||
                    (this.PhotoCount != null &&
                    this.PhotoCount.Equals(input.PhotoCount))
                ) && base.Equals(input) && 
                (
                    this.TotalPhotoCount == input.TotalPhotoCount ||
                    (this.TotalPhotoCount != null &&
                    this.TotalPhotoCount.Equals(input.TotalPhotoCount))
                ) && base.Equals(input) && 
                (
                    this.Map == input.Map ||
                    (this.Map != null &&
                    this.Map.Equals(input.Map))
                ) && base.Equals(input) && 
                (
                    this.Trainer == input.Trainer ||
                    (this.Trainer != null &&
                    this.Trainer.Equals(input.Trainer))
                ) && base.Equals(input) && 
                (
                    this.Commute == input.Commute ||
                    (this.Commute != null &&
                    this.Commute.Equals(input.Commute))
                ) && base.Equals(input) && 
                (
                    this.Manual == input.Manual ||
                    (this.Manual != null &&
                    this.Manual.Equals(input.Manual))
                ) && base.Equals(input) && 
                (
                    this._Private == input._Private ||
                    (this._Private != null &&
                    this._Private.Equals(input._Private))
                ) && base.Equals(input) && 
                (
                    this.Flagged == input.Flagged ||
                    (this.Flagged != null &&
                    this.Flagged.Equals(input.Flagged))
                ) && base.Equals(input) && 
                (
                    this.WorkoutType == input.WorkoutType ||
                    (this.WorkoutType != null &&
                    this.WorkoutType.Equals(input.WorkoutType))
                ) && base.Equals(input) && 
                (
                    this.UploadIdStr == input.UploadIdStr ||
                    (this.UploadIdStr != null &&
                    this.UploadIdStr.Equals(input.UploadIdStr))
                ) && base.Equals(input) && 
                (
                    this.AverageSpeed == input.AverageSpeed ||
                    (this.AverageSpeed != null &&
                    this.AverageSpeed.Equals(input.AverageSpeed))
                ) && base.Equals(input) && 
                (
                    this.MaxSpeed == input.MaxSpeed ||
                    (this.MaxSpeed != null &&
                    this.MaxSpeed.Equals(input.MaxSpeed))
                ) && base.Equals(input) && 
                (
                    this.HasKudoed == input.HasKudoed ||
                    (this.HasKudoed != null &&
                    this.HasKudoed.Equals(input.HasKudoed))
                ) && base.Equals(input) && 
                (
                    this.HideFromHome == input.HideFromHome ||
                    (this.HideFromHome != null &&
                    this.HideFromHome.Equals(input.HideFromHome))
                ) && base.Equals(input) && 
                (
                    this.GearId == input.GearId ||
                    (this.GearId != null &&
                    this.GearId.Equals(input.GearId))
                ) && base.Equals(input) && 
                (
                    this.Kilojoules == input.Kilojoules ||
                    (this.Kilojoules != null &&
                    this.Kilojoules.Equals(input.Kilojoules))
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
                    this.MaxWatts == input.MaxWatts ||
                    (this.MaxWatts != null &&
                    this.MaxWatts.Equals(input.MaxWatts))
                ) && base.Equals(input) && 
                (
                    this.WeightedAverageWatts == input.WeightedAverageWatts ||
                    (this.WeightedAverageWatts != null &&
                    this.WeightedAverageWatts.Equals(input.WeightedAverageWatts))
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
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.UploadId != null)
                    hashCode = hashCode * 59 + this.UploadId.GetHashCode();
                if (this.Athlete != null)
                    hashCode = hashCode * 59 + this.Athlete.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.MovingTime != null)
                    hashCode = hashCode * 59 + this.MovingTime.GetHashCode();
                if (this.ElapsedTime != null)
                    hashCode = hashCode * 59 + this.ElapsedTime.GetHashCode();
                if (this.TotalElevationGain != null)
                    hashCode = hashCode * 59 + this.TotalElevationGain.GetHashCode();
                if (this.ElevHigh != null)
                    hashCode = hashCode * 59 + this.ElevHigh.GetHashCode();
                if (this.ElevLow != null)
                    hashCode = hashCode * 59 + this.ElevLow.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.StartDateLocal != null)
                    hashCode = hashCode * 59 + this.StartDateLocal.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.StartLatlng != null)
                    hashCode = hashCode * 59 + this.StartLatlng.GetHashCode();
                if (this.EndLatlng != null)
                    hashCode = hashCode * 59 + this.EndLatlng.GetHashCode();
                if (this.AchievementCount != null)
                    hashCode = hashCode * 59 + this.AchievementCount.GetHashCode();
                if (this.KudosCount != null)
                    hashCode = hashCode * 59 + this.KudosCount.GetHashCode();
                if (this.CommentCount != null)
                    hashCode = hashCode * 59 + this.CommentCount.GetHashCode();
                if (this.AthleteCount != null)
                    hashCode = hashCode * 59 + this.AthleteCount.GetHashCode();
                if (this.PhotoCount != null)
                    hashCode = hashCode * 59 + this.PhotoCount.GetHashCode();
                if (this.TotalPhotoCount != null)
                    hashCode = hashCode * 59 + this.TotalPhotoCount.GetHashCode();
                if (this.Map != null)
                    hashCode = hashCode * 59 + this.Map.GetHashCode();
                if (this.Trainer != null)
                    hashCode = hashCode * 59 + this.Trainer.GetHashCode();
                if (this.Commute != null)
                    hashCode = hashCode * 59 + this.Commute.GetHashCode();
                if (this.Manual != null)
                    hashCode = hashCode * 59 + this.Manual.GetHashCode();
                if (this._Private != null)
                    hashCode = hashCode * 59 + this._Private.GetHashCode();
                if (this.Flagged != null)
                    hashCode = hashCode * 59 + this.Flagged.GetHashCode();
                if (this.WorkoutType != null)
                    hashCode = hashCode * 59 + this.WorkoutType.GetHashCode();
                if (this.UploadIdStr != null)
                    hashCode = hashCode * 59 + this.UploadIdStr.GetHashCode();
                if (this.AverageSpeed != null)
                    hashCode = hashCode * 59 + this.AverageSpeed.GetHashCode();
                if (this.MaxSpeed != null)
                    hashCode = hashCode * 59 + this.MaxSpeed.GetHashCode();
                if (this.HasKudoed != null)
                    hashCode = hashCode * 59 + this.HasKudoed.GetHashCode();
                if (this.HideFromHome != null)
                    hashCode = hashCode * 59 + this.HideFromHome.GetHashCode();
                if (this.GearId != null)
                    hashCode = hashCode * 59 + this.GearId.GetHashCode();
                if (this.Kilojoules != null)
                    hashCode = hashCode * 59 + this.Kilojoules.GetHashCode();
                if (this.AverageWatts != null)
                    hashCode = hashCode * 59 + this.AverageWatts.GetHashCode();
                if (this.DeviceWatts != null)
                    hashCode = hashCode * 59 + this.DeviceWatts.GetHashCode();
                if (this.MaxWatts != null)
                    hashCode = hashCode * 59 + this.MaxWatts.GetHashCode();
                if (this.WeightedAverageWatts != null)
                    hashCode = hashCode * 59 + this.WeightedAverageWatts.GetHashCode();
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
