/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using System.Security.Claims;

namespace MyActiveLife.Apis.MyFitnessPal.OAuth
{
    /// <summary>
    /// Defines a set of options used by <see cref="MyFitnessPalAuthenticationHandler"/>.
    /// </summary>
    public class MyFitnessPalAuthenticationOptions : OAuthOptions
    {
        public MyFitnessPalAuthenticationOptions()
        {
            ClaimsIssuer = MyFitnessPalAuthenticationDefaults.Issuer;

            CallbackPath = MyFitnessPalAuthenticationDefaults.CallbackPath;

            AuthorizationEndpoint = MyFitnessPalAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = MyFitnessPalAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = MyFitnessPalAuthenticationDefaults.UserInformationEndpoint;

            Scope.Add("read");
            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "username");
            ClaimActions.MapJsonKey(ClaimTypes.GivenName, "firstname");
            ClaimActions.MapJsonKey(ClaimTypes.Surname, "lastname");
            ClaimActions.MapJsonKey(ClaimTypes.Email, "email");
            ClaimActions.MapJsonKey(ClaimTypes.StateOrProvince, "state");
            ClaimActions.MapJsonKey(ClaimTypes.Country, "country");
            ClaimActions.MapJsonKey(ClaimTypes.Gender, "sex");
        }
    }
}