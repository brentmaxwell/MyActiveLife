/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using JetBrains.Annotations;
using Microsoft.AspNetCore.Authentication;
using MyActiveLife.Apis.Withings.OAuth;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods to add Withings authentication capabilities to an HTTP application pipeline.
    /// </summary>
    public static class WithingsAuthenticationExtensions
    {
        /// <summary>
        /// Adds <see cref="WithingsAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Strava authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddWithings([NotNull] this AuthenticationBuilder builder)
        {
            return builder.AddWithings(WithingsAuthenticationDefaults.AuthenticationScheme, options => { });
        }

        /// <summary>
        /// Adds <see cref="WithingsAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Strava authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="configuration">The delegate used to configure the Strava options.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddWithings(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] Action<WithingsAuthenticationOptions> configuration)
        {
            return builder.AddWithings(WithingsAuthenticationDefaults.AuthenticationScheme, configuration);
        }

        /// <summary>
        /// Adds <see cref="WithingsAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Strava authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the Strava options.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddWithings(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme,
            [NotNull] Action<WithingsAuthenticationOptions> configuration)
        {
            return builder.AddWithings(scheme, WithingsAuthenticationDefaults.DisplayName, configuration);
        }

        /// <summary>
        /// Adds <see cref="WithingsAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Strava authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="caption">The optional display name associated with this instance</param>
        /// <param name="configuration">The delegate used to configure the Strava options.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddWithings(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme,
            [CanBeNull] string caption,
            [NotNull] Action<WithingsAuthenticationOptions> configuration)
        {
            return builder.AddOAuth<WithingsAuthenticationOptions, WithingsAuthenticationHandler>(scheme, caption, configuration);
        }
    }
}