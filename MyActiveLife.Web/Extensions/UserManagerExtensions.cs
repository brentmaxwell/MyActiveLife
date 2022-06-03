using Microsoft.AspNetCore.Identity;
using MyActiveLife.Library;

namespace MyActiveLife.Web.Extensions
{
    public static class UserManagerExtensions
    {
        public static async Task<string> GetAccessToken(this UserManager<IdentityUser> userManager, IdentityUser user, string provider, string clientId, string clientSecret)
        {
            var tokenExpires = DateTime.Parse(await userManager.GetAuthenticationTokenAsync(user, provider, "expires_at"));
            if (tokenExpires < DateTime.Now)
            {
                var refreshToken = await userManager.GetAuthenticationTokenAsync(user, provider, "refresh_token");
                var tokenClient = new TokenClient(clientId, clientSecret);
                var authTokens = await tokenClient.RefreshToken(refreshToken);
                foreach (var authToken in authTokens)
                {
                    await userManager.SetAuthenticationTokenAsync(user, provider, authToken.Name, authToken.Value);
                }
            }
            return await userManager.GetAuthenticationTokenAsync(user, provider, "access_token");
        }
    }
}
