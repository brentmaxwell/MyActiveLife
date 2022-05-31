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
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("profile_medium")]
        public string ProfileMedium { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("friend")]
        public string Friend { get; set; }

        [JsonProperty("follower")]
        public string Follower { get; set; }

        [JsonProperty("premium")]
        public bool? Premium { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("approve_followers")]
        public bool? ApproveFollowers { get; set; }

        [JsonProperty("follower_count")]
        public int? FollowerCount { get; set; }

        [JsonProperty("friend_count")]
        public int? FriendCount { get; set; }

        [JsonProperty("mutual_friend_count")]
        public int? MutualFriendCount { get; set; }

        [JsonProperty("date_preference")]
        public string DatePreference { get; set; }

        [JsonProperty("measurement_preference")]
        public string MeasurementPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("ftp")]
        public int? Ftp { get; set; }

        [JsonProperty("clubs")]
        public ICollection<Club> Clubs { get; set; }

        [JsonProperty("bikes")]
        public ICollection<Bike> Bikes { get; set; }

        [JsonProperty("shoes")]
        public ICollection<Shoe> Shoes { get; set; }
    }
}
