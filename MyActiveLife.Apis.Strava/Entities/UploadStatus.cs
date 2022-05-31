using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Entities
{
    public class UploadStatus
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        //may be null
        [JsonProperty("activity_id")]
        public int? ActivityId { get; set; }

        //describes the error, possible values: ‘Your activity is still being processed.’, ‘The created activity has been deleted.’, ‘There was an error processing your activity.’, ‘Your activity is ready.’
        [JsonProperty("status")]
        public string Status { get; set; }

        //if there was an error during processing, this will contain a human a human readable error message that may include escaped HTML
        //may be null 
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
