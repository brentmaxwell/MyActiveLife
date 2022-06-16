using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class Club : Resource
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        //URL to a 62x62 pixel profile picture
        [JsonProperty("profile_medium")]
        public string ProfileMedium { get; set; }

        //URL to a 124x124 pixel profile picture
        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        //casual_club, racing_team, shop, company, other
        [JsonProperty("club_type")]
        public string ClubType { get; set; }

        //cycling, running, triathlon, other
        [JsonProperty("sport_type")]
        public string SportType { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("private")]
        public bool? Private { get; set; }

        [JsonProperty("member_count")]
        public int? MemberCount { get; set; }
    }
}
