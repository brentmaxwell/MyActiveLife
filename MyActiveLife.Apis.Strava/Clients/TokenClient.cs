using Microsoft.AspNetCore.Authentication;
using Newtonsoft.Json;
using MyActiveLife.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Strava.Clients
{
    public class TokenClient
    {
        public const string TokenUrl = "https://www.strava.com/oauth/token";
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string RedirectUri { get; set; }
        protected HttpClient HttpClient;
        public TokenClient(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            HttpClient = new HttpClient();
        }

        public TokenClient(string clientId, string clientSecret, string redirectUri) : this(clientId, clientSecret)
        {
            RedirectUri = redirectUri;
        }

        public async Task<IEnumerable<AuthenticationToken>> RefreshToken(string refreshToken)
        {
            var url = TokenUrl;
            var parameters = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("client_id", ClientId),
                new KeyValuePair<string, string>("client_secret", ClientSecret),
                new KeyValuePair<string, string>("grant_type","refresh_token"),
                new KeyValuePair<string, string>("refresh_token",refreshToken)
            };

            var requestContent = new FormUrlEncodedContent(parameters);
            HttpResponseMessage response = await HttpClient.PostAsync(url,requestContent);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            var tokenInfo = JsonConvert.DeserializeObject<TokenInfo>(data);
            return tokenInfo.ToAuthenticationTokens();
        }
    }

    public class TokenInfo
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }
        [JsonProperty("expires_in")]
        public string ExpiresIn { get; set; }
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        public List<AuthenticationToken> ToAuthenticationTokens()
        {
            return new List<AuthenticationToken>()
            {
                new AuthenticationToken() { Name = "access_token", Value = AccessToken},
                new AuthenticationToken() { Name = "expires_at", Value = DateTimeExtensions.FromUnixTime(long.Parse(ExpiresAt)).ToString() },
                new AuthenticationToken() { Name = "expires_in", Value = ExpiresIn},
                new AuthenticationToken() { Name = "refresh_token", Value = RefreshToken},
            };
        } 
    }
}
