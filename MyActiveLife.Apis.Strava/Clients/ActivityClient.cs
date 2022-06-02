using MyActiveLife.Apis.Strava.Entities;
using MyActiveLife.Library.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using MyActiveLife.Library;

namespace MyActiveLife.Apis.Strava.Clients
{
    public class ActivityClient : ApiClient
    {
        public ActivityClient(string authToken) : base(authToken)
        {
        }

        /// <summary>
        /// Get one activity
        /// </summary>
        /// <param name="activityId">The identifier of the activity</param>
        /// <param name="includeAllEfforts">True to include all segments efforts</param>
        /// <returns>An Activity object</returns>
        public async Task<Activity> GetAsync(int activityId, bool? includeAllEfforts = null)
        {
            string queryString = "?";
            if (includeAllEfforts.HasValue)
            {
                queryString += "include_all_efforts=" + includeAllEfforts + "&";
            }
            queryString = queryString.TrimEnd(new[] { '?', '&' });
            Activity activity = await GetAsync<Activity>(Endpoints.ActivitiesEndpointUrl + activityId + queryString);
            activity.ActivityStreamPoints = await GetActivityStreamAsync(activity.Id);
            return activity;
        }

        /// <summary>
        /// Get a list of activities
        /// </summary>
        /// <param name="before">An epoch timestamp to use for filtering activities that have taken place before a certain time</param>
        /// <param name="after">An epoch timestamp to use for filtering activities that have taken place after a certain time</param>
        /// <param name="page">Page number. Defaults to 1</param>
        /// <param name="perPage">Number of items per page. Defaults to 30</param>
        /// <param name="includeDetails"></param>
        /// <returns>An ICollection of Activity objects</returns>
        public async Task<ICollection<Activity>> GetAsync(DateTime? before = null, DateTime? after = null,
            int? page = null, int? perPage = null, bool includeDetails = false)
        {
            string queryString = "?";
            if (before.HasValue)
            {
                queryString += "before=" + before.Value.ToUnixTime() + "&";
            }
            if (after.HasValue)
            {
                queryString += "after=" + after.Value.ToUnixTime() + "&";
            }
            if (page.HasValue)
            {
                queryString += "page=" + page.Value + "&";
            }
            if (perPage.HasValue)
            {
                queryString += "per_page=" + perPage.Value + "&";
            }
            queryString = queryString.TrimEnd(new[] { '?', '&' });
            ICollection<Activity> activities =
                await GetAsync<ICollection<Activity>>(Endpoints.AthleteActivitiesEndpointUrl + queryString);
            if (includeDetails)
            {
                foreach (Activity activity in activities)
                {
                    activity.ActivityStreamPoints = await GetActivityStreamAsync(activity.Id);
                }
            }
            return activities;
        }

        /// <summary>
        /// Gets the data streams for an activity
        /// </summary>
        /// <param name="activityId">The identifier of the activity</param>
        /// <returns>A list of ActivityStream objects</returns>
        public async Task<List<ActivityStreamPoint>> GetActivityStreamAsync(string activityId)
        {
            var activityStreamPoint = new List<ActivityStreamPoint>();
            try
            {
                Stream<object>[] stream = await
                    GetAsync<Stream<object>[]>(Endpoints.ActivitiesEndpointUrl + "/" + activityId +
                                               "/streams/time,latlng,distance,altitude,velocity_smooth,heartrate,cadence,watts,temp,moving,grade");

                Stream<object> timeStream = stream.SingleOrDefault(x => x.Type == "time");
                Stream<object> latlngStream = stream.SingleOrDefault(x => x.Type == "latlng");

                Stream<object> distanceStream = stream.SingleOrDefault(x => x.Type == "distance");
                Stream<object> altitudeStream = stream.SingleOrDefault(x => x.Type == "altitude");
                Stream<object> velocityStream = stream.SingleOrDefault(x => x.Type == "velocity_smooth");
                Stream<object> heartrateStream = stream.SingleOrDefault(x => x.Type == "heartrate");
                Stream<object> cadenceStream = stream.SingleOrDefault(x => x.Type == "cadence");
                Stream<object> wattsStream = stream.SingleOrDefault(x => x.Type == "watts");
                Stream<object> tempStream = stream.SingleOrDefault(x => x.Type == "temp");
                Stream<object> movingStream = stream.SingleOrDefault(x => x.Type == "moving");
                Stream<object> gradeStream = stream.SingleOrDefault(x => x.Type == "grade");
                if (timeStream != null)
                    activityStreamPoint.AddRange(timeStream.Data.Select((t, i) => new ActivityStreamPoint
                    {
                        Time = int.Parse(t.ToString()),
                        Latitude =
                            latlngStream != null && latlngStream.Data[i] != null
                                ? float.Parse(((JArray)latlngStream.Data[i])[0].ToString())
                                : (float?)null,
                        Longitude =
                            latlngStream != null && latlngStream.Data[i] != null
                                ? float.Parse(((JArray)latlngStream.Data[i])[1].ToString())
                                : (float?)null,
                        Distance =
                            distanceStream != null && distanceStream.Data[i] != null
                                ? float.Parse(distanceStream.Data[i].ToString())
                                : (float?)null,
                        Altitude =
                            altitudeStream != null && altitudeStream.Data[i] != null
                                ? float.Parse(altitudeStream.Data[i].ToString())
                                : (float?)null,
                        Velocity =
                            velocityStream != null && velocityStream.Data[i] != null
                                ? float.Parse(velocityStream.Data[i].ToString())
                                : (float?)null,
                        Heartrate =
                            heartrateStream != null && heartrateStream.Data[i] != null
                                ? int.Parse(heartrateStream.Data[i].ToString())
                                : (int?)null,
                        Cadence =
                            cadenceStream != null && cadenceStream.Data[i] != null
                                ? int.Parse(cadenceStream.Data[i].ToString())
                                : (int?)null,
                        Watts =
                            wattsStream != null && wattsStream.Data[i] != null
                                ? int.Parse(wattsStream.Data[i].ToString())
                                : (int?)null,
                        Temp =
                            tempStream != null && tempStream.Data[i] != null
                                ? float.Parse(tempStream.Data[i].ToString())
                                : (float?)null,
                        Moving =
                            movingStream != null && movingStream.Data[i] != null
                                ? bool.Parse(movingStream.Data[i].ToString())
                                : (bool?)null,
                        Grade =
                            gradeStream != null && gradeStream.Data[i] != null
                                ? float.Parse(gradeStream.Data[i].ToString())
                                : (float?)null
                    }));
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch
            // ReSharper restore EmptyGeneralCatchClause
            {
            }
            return activityStreamPoint;
        }

        public async Task<ICollection<Activity>> GetFollowingAsync(int? page = null, int? perPage = null)
        {
            string queryString = "?";
            if (page.HasValue)
            {
                queryString += "page=" + page + "&";
            }
            if (perPage.HasValue)
            {
                queryString += "per_page=" + perPage + "&";
            }
            queryString = queryString.TrimEnd(new[] { '?', '&' });
            return await GetAsync<ICollection<Activity>>(Endpoints.ActivitiesFollowingEndpointUrl + queryString);
        }

        //public async Task<UploadStatus> UploadTCX(string name, string fileName, byte[] file)
        //{
        //    var content = new MultipartFormDataContent();
        //    content.Add(new ByteArrayContent(file), "file", fileName);

        //    var queryString = Endpoints.UploadEndpointUrl + "?data_type=tcx";
        //    if (name != null)
        //    {
        //        queryString += "&name=" + name;
        //    }

        //    return await PostAsync<UploadStatus>(queryString, content);
        //}

        //public async Task<UploadStatus> GetUploadStatus(string id)
        //{
        //    return await GetAsync<UploadStatus>(Endpoints.UploadEndpointUrl + "/" + id);
        //}
    }
}
