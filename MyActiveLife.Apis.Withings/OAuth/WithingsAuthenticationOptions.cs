/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using System.Security.Claims;

namespace MyActiveLife.Apis.Withings.OAuth
{
    /// <summary>
    /// Defines a set of options used by <see cref="WithingsAuthenticationHandler"/>.
    /// </summary>
    public class WithingsAuthenticationOptions : OAuthOptions
    {
        public WithingsAuthenticationOptions()
        {
            ClaimsIssuer = WithingsAuthenticationDefaults.Issuer;

            CallbackPath = WithingsAuthenticationDefaults.CallbackPath;

            AuthorizationEndpoint = WithingsAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = WithingsAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = WithingsAuthenticationDefaults.UserInformationEndpoint;

            Scope.Add("user.activity");
            Scope.Add("user.metrics");
        }
    }
}