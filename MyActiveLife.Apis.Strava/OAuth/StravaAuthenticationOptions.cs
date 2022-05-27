/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using System.Security.Claims;

namespace MyActiveLife.Apis.Strava.OAuth
{
    /// <summary>
    /// Defines a set of options used by <see cref="StravaAuthenticationHandler"/>.
    /// </summary>
    public class StravaAuthenticationOptions : OAuthOptions
    {
        public StravaAuthenticationOptions()
        {
            ClaimsIssuer = StravaAuthenticationDefaults.Issuer;

            CallbackPath = StravaAuthenticationDefaults.CallbackPath;

            AuthorizationEndpoint = StravaAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = StravaAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = StravaAuthenticationDefaults.UserInformationEndpoint;

            Scope.Add("read");

            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "username");
            ClaimActions.MapJsonKey(ClaimTypes.GivenName, "firstname");
            ClaimActions.MapJsonKey(ClaimTypes.Surname, "lastname");
            ClaimActions.MapJsonKey(ClaimTypes.Email, "email");
            ClaimActions.MapJsonKey(ClaimTypes.StateOrProvince, "state");
            ClaimActions.MapJsonKey(ClaimTypes.Country, "country");
            ClaimActions.MapJsonKey(ClaimTypes.Gender, "sex");
            ClaimActions.MapJsonKey(StravaAuthenticationConstants.Claims.City, "city");
            ClaimActions.MapJsonKey(StravaAuthenticationConstants.Claims.Profile, "profile");
            ClaimActions.MapJsonKey(StravaAuthenticationConstants.Claims.ProfileMedium, "profile_medium");
            ClaimActions.MapJsonKey(StravaAuthenticationConstants.Claims.CreatedAt, "created_at");
            ClaimActions.MapJsonKey(StravaAuthenticationConstants.Claims.UpdatedAt, "updated_at");
            ClaimActions.MapJsonKey(StravaAuthenticationConstants.Claims.Premium, "premium");
        }
    }
}