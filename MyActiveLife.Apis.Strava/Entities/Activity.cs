using MyActiveLife.Apis.Google;
using MyActiveLife.Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class Activity : Resource
    {
        /// <summary>
        /// The identifier provided at upload time
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// The identifier of the upload that resulted in this activity
        /// </summary>
        [JsonProperty("upload_id")]
        public string UploadId { get; set; }

        /// <summary>
        /// Gets or Sets Athlete
        /// </summary>
        [JsonProperty("athlete")]
        public Athlete Athlete { get; set; }

        /// <summary>
        /// The name of the activity
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The activity's distance, in meters
        /// </summary>
        [JsonProperty("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// The activity's moving time, in seconds
        /// </summary>
        [JsonProperty("moving_time")]
        public int? MovingTime { get; set; }

        /// <summary>
        /// The activity's elapsed time, in seconds
        /// </summary>
        [JsonProperty("elapsed_time")]
        public int? ElapsedTime { get; set; }

        /// <summary>
        /// The activity's total elevation gain.
        /// </summary>
        [JsonProperty("total_elevation_gain")]
        public float? TotalElevationGain { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The time at which the activity was started.
        /// </summary>
        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The time at which the activity was started in the local timezone.
        /// </summary>
        [JsonProperty("start_date_local")]
        public DateTime StartDateLocal { get; set; }

        /// <summary>
        /// The timezone of the activity
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("utc_offset")]
        public float? UtcOffset { get; set; }

        /// <summary>
        /// Gets or Sets StartLatlng
        /// </summary>
        [JsonProperty("start_latlng")]
        public LatLng StartLatLng { get; set; }

        /// <summary>
        /// Gets or Sets EndLatlng
        /// </summary>
        [JsonProperty("end_latlng")]
        public LatLng EndLatLng { get; set; }

        /// <summary>
        /// The number of achievements gained during this activity
        /// </summary>
        [JsonProperty("achievement_count")]
        public int? AchievementCount { get; set; }

        /// <summary>
        /// The number of kudos given for this activity
        /// </summary>
        [JsonProperty("kudos_count")]
        public int? KudosCount { get; set; }

        /// <summary>
        /// The number of comments for this activity
        /// </summary>
        [JsonProperty("comment_count")]
        public int? CommentCount { get; set; }

        /// <summary>
        /// The number of athletes for taking part in a group activity
        /// </summary>
        [JsonProperty("athlete_count")]
        public int? AthleteCount { get; set; }

        /// <summary>
        /// The number of Instagram photos for this activity
        /// </summary>
        [JsonProperty("photo_count")]
        public int? PhotoCount { get; set; }

        /// <summary>
        /// Gets or Sets Map
        /// </summary>
        [JsonProperty("map")]
        public Map Map { get; set; }

        /// <summary>
        /// Whether this activity was recorded on a training machine
        /// </summary>
        [JsonProperty("trainer")]
        public bool Trainer { get; set; }

        /// <summary>
        /// Whether this activity is a commute
        /// </summary>
        [JsonProperty("commute")]
        public bool Commute { get; set; }

        /// <summary>
        /// Whether this activity was created manually
        /// </summary>
        [JsonProperty("manual")]
        public bool Manual { get; set; }

        /// <summary>
        /// Whether this activity is private
        /// </summary>
        [JsonProperty("private")]
        public bool Private { get; set; }

        /// <summary>
        /// Whether this activity is flagged
        /// </summary>
        [JsonProperty("flagged")]
        public bool Flagged { get; set; }

        /// <summary>
        /// The id of the gear for the activity
        /// </summary>
        [JsonProperty("gear_id")]
        public string GearId { get; set; }

        [JsonProperty("from_accepted_tag")]
        public bool FromAcceptedTag { get; set; }

        /// <summary>
        /// The activity's average speed, in meters per second
        /// </summary>
        [JsonProperty("average_speed")]
        public float? AverageSpeed { get; set; }

        /// <summary>
        /// The activity's max speed, in meters per second
        /// </summary>
        [JsonProperty("max_speed")]
        public float? MaxSpeed { get; set; }

        [JsonProperty("average_cadence")]
        public float? AverageCadence { get; set; }

        [JsonProperty("average_temp")]
        public float? AverageTemp { get; set; }

        /// <summary>
        /// Average power output in watts during this activity. Rides only
        /// </summary>
        [JsonProperty("average_watts")]
        public float? AverageWatts { get; set; }

        /// <summary>
        /// Similar to Normalized Power. Rides with power meter data only
        /// </summary>
        [JsonProperty("weighted_average_watts")]
        public float? WeightedAverageWatts { get; set; }

        /// <summary>
        /// The total work done in kilojoules during this activity. Rides only
        /// </summary>
        [JsonProperty("kilojoules")]
        public float? Kilojoules { get; set; }

        /// <summary>
        /// Whether the watts are from a power meter, false if estimated
        /// </summary>
        [JsonProperty("device_watts")]
        public bool DeviceWatts { get; set; }

        [JsonProperty("has_heartrate")]
        public bool HasHeartrate { get; set; }

        /// <summary>
        /// Rides with power meter data only
        /// </summary>
        [JsonProperty("max_watts")]
        public float? MaxWatts { get; set; }

        /// <summary>
        /// The activity's highest elevation, in meters
        /// </summary>
        [JsonProperty("elev_high")]
        public float? ElevationHigh { get; set; }

        /// <summary>
        /// The activity's lowest elevation, in meters
        /// </summary>
        [JsonProperty("elev_low")]
        public float? ElevationLow { get; set; }

        [JsonProperty("pr_count")]
        public int? PrCount { get; set; }

        /// <summary>
        /// The number of Instagram and Strava photos for this activity
        /// </summary>
        [JsonProperty("total_photo_count")]
        public int? TotalPhotoCount { get; set; }

        /// <summary>
        /// Whether the logged-in athlete has kudoed this activity
        /// </summary>
        [JsonProperty("has_kudoed")]
        public bool HasKudoed { get; set; }

        /// <summary>
        /// The activity's workout type
        /// </summary>
        [JsonProperty("workout_type")]
        public int? WorkoutType { get; set; }

        [JsonProperty("suffer_score")]
        public float? SufferScore { get; set; }

        /// <summary>
        /// The description of the activity
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The number of kilocalories consumed during this activity
        /// </summary>
        [JsonProperty("calories")]
        public float? Calories { get; set; }

        /// <summary>
        /// Gets or Sets SegmentEfforts
        /// </summary>
        [JsonProperty("segment_efforts")]
        public List<SegmentEffort> SegmentEfforts { get; set; }

        /// <summary>
        /// The splits of this activity in metric units (for runs)
        /// </summary>
        [JsonProperty("splits_metric")]
        public List<Split> SplitsMetric { get; set; }

        /// <summary>
        /// Gets or Sets Laps
        /// </summary>
        [JsonProperty("laps")]
        public List<Lap> Laps { get; set; }

        /// <summary>
        /// Gets or Sets Gear
        /// </summary>
        [JsonProperty("gear")]
        public Gear Gear { get; set; }

        [JsonProperty("partner_brand_tag")]
        public string PartnerBrandTag { get; set; }

        /// <summary>
        /// Gets or Sets Photos
        /// </summary>
        [JsonProperty("photos")]
        public List<Photo> Photos { get; set; }

        [JsonProperty("highlighted_kudosers")]
        public List<Athlete> HighlightedKudosers { get; set; }

        /// <summary>
        /// Whether the activity is muted
        /// </summary>
        [JsonProperty("hide_from_home")]
        public bool HideFromHome { get; set; }

        /// <summary>
        /// The name of the device used to record the activity
        /// </summary>
        [JsonProperty("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// The token used to embed a Strava activity
        /// </summary>
        [JsonProperty("embed_token")]
        public string EmbedToken { get; set; }

        [JsonProperty("segment_leaderboard_opt_out")]
        public bool SegmentLeaderboardOptOut { get; set; }

        [JsonProperty("leaderboard_opt_out")]
        public bool LeaderboardOptOut { get; set; }

        public List<ActivityStreamPoint> ActivityStreamPoints { get; set; }
    }
}
