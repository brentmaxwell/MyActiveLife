/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using JetBrains.Annotations;
using Microsoft.AspNetCore.Authentication;
using MyActiveLife.Apis.MyFitnessPal.OAuth;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods to add MyFitnessPal authentication capabilities to an HTTP application pipeline.
    /// </summary>
    public static class MyFitnessPalAuthenticationExtensions
    {
        /// <summary>
        /// Adds <see cref="MyFitnessPalAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables MyFitnessPal authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddMyFitnessPal([NotNull] this AuthenticationBuilder builder)
        {
            return builder.AddMyFitnessPal(MyFitnessPalAuthenticationDefaults.AuthenticationScheme, options => { });
        }

        /// <summary>
        /// Adds <see cref="MyFitnessPalAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables MyFitnessPal authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="configuration">The delegate used to configure the MyFitnessPal options.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddMyFitnessPal(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] Action<MyFitnessPalAuthenticationOptions> configuration)
        {
            return builder.AddMyFitnessPal(MyFitnessPalAuthenticationDefaults.AuthenticationScheme, configuration);
        }

        /// <summary>
        /// Adds <see cref="MyFitnessPalAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables MyFitnessPal authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the MyFitnessPal options.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddMyFitnessPal(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme,
            [NotNull] Action<MyFitnessPalAuthenticationOptions> configuration)
        {
            return builder.AddMyFitnessPal(scheme, MyFitnessPalAuthenticationDefaults.DisplayName, configuration);
        }

        /// <summary>
        /// Adds <see cref="MyFitnessPalAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables MyFitnessPal authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="caption">The optional display name associated with this instance</param>
        /// <param name="configuration">The delegate used to configure the MyFitnessPal options.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddMyFitnessPal(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme,
            [CanBeNull] string caption,
            [NotNull] Action<MyFitnessPalAuthenticationOptions> configuration)
        {
            return builder.AddOAuth<MyFitnessPalAuthenticationOptions, MyFitnessPalAuthenticationHandler>(scheme, caption, configuration);
        }
    }
}