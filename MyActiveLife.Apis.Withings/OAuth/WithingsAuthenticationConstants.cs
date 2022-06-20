/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

namespace MyActiveLife.Apis.Strava.OAuth
{
    /// <summary>
    /// Contains constants specific to the <see cref="WithingsAuthenticationHandler"/>.
    /// </summary>
    public static class WithingsAuthenticationConstants
    {
        public static class Claims
        {
            public const string City = "urn:strava:city";
            public const string CreatedAt = "urn:strava:created-at";
            public const string Premium = "urn:strava:premium";
            public const string Profile = "urn:strava:profile";
            public const string ProfileMedium = "urn:strava:profile-medium";
            public const string UpdatedAt = "urn:strava:updated-at";
        }
    }
}