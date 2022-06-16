using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava
{
    public static class Endpoints
    {
        public const string BaseEndpointUrl = "https://www.strava.com/api/v3/";

        #region Athlete

        public const string AthleteEndpointUrl = BaseEndpointUrl + "athlete";
        public const string AthletesEndpointUrl = BaseEndpointUrl + "athletes";

        #endregion

        #region Activities

        public const string ActivitiesEndpointUrl = BaseEndpointUrl + "/activities";
        public const string AthleteActivitiesEndpointUrl = AthleteEndpointUrl + "/activities";
        public const string ActivitiesFollowingEndpointUrl = ActivitiesEndpointUrl + "/following";

        #endregion

        #region Clubs

        public const string AthleteClubsEndpointUrl = AthleteEndpointUrl + "/clubs";
        public const string ClubEndpointUrl = BaseEndpointUrl + "clubs/";

        #endregion

        #region Gear

        public const string GearEndpointUrl = BaseEndpointUrl + "gear/";

        #endregion

        #region Uploads

        public const string UploadEndpointUrl = BaseEndpointUrl + "uploads";

        #endregion
    }
}
