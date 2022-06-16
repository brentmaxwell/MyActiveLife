using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class Athlete : Resource
    {
        /// <summary>
        /// The athlete's first name
        /// </summary>
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// The athlete's last name
        /// </summary>
        [JsonProperty("lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// URL to a 62x62 pixel profile picture
        /// </summary>
        [JsonProperty("profile_medium")]
        public string ProfileMedium { get; set; }

        /// <summary>
        /// URL to a 124x124 pixel profile picture
        /// </summary>
        [JsonProperty("profile")]
        public string Profile { get; set; }

        /// <summary>
        /// The athlete's city
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The athlete's state or geographical region
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The athlete's country
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The athlete's sex. May take one of the following values: M, F
        /// </summary>
        [JsonProperty("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// Whether the athlete has any Summit subscription
        /// </summary>
        [JsonProperty("summit")]
        public bool Summit { get; set; }

        /// <summary>
        /// The time at which the athlete was created
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time at which the athlete was last updated
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The athlete's follower count
        /// </summary>
        [JsonProperty("follower_count")]
        public int? FollowerCount { get; set; }

        /// <summary>
        /// The athlete's friend count
        /// </summary>
        [JsonProperty("friend_count")]
        public int? FriendCount { get; set; }

        /// <summary>
        /// The athlete's prefered date format
        /// </summary>
        [JsonProperty("date_preference")]
        public string DatePreference { get; set; }

        /// <summary>
        /// The athlete's preferred unit system. May take one of the following values: feet, meters
        /// </summary>
        [JsonProperty("measurement_preference")]
        public string MeasurementPreference { get; set; }

        /// <summary>
        /// The athlete's FTP (Functional Threshold Power)
        /// </summary>
        [JsonProperty("ftp")]
        public int? Ftp { get; set; }

        /// <summary>
        /// The athlete's weight
        /// </summary>
        [JsonProperty("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// The athlete's clubs
        /// </summary>
        [JsonProperty("clubs")]
        public ICollection<Club> Clubs { get; set; }

        /// <summary>
        /// The athlete's bikes
        /// </summary>
        [JsonProperty("bikes")]
        public ICollection<Bike> Bikes { get; set; }

        /// <summary>
        /// The athlete's shoes
        /// </summary>
        [JsonProperty("shoes")]
        public ICollection<Shoe> Shoes { get; set; }
    }
}
