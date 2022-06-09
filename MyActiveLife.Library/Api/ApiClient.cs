using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Library.Api
{
    public abstract class ApiClient
    {
        protected string AuthToken;
        protected HttpClient HttpClient;

        public ApiClient()
        {
            HttpClient = new HttpClient();
        }
        public ApiClient(string authToken) : base()
        {
            AuthToken = authToken;
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthToken);
        }

        protected async Task<T> GetAsync<T>(string url)
        {
            string response = await GetJsonRequestAsync(url);
            //var jobject = JObject.Parse(response as string);
            return JsonConvert.DeserializeObject<T>(response);
        }

        protected async Task<T> PostAsync<T>(string url, List<KeyValuePair<string, string>> parameters)
        {
            string response = await PostJsonRequestAsync(url, parameters);
            return JsonConvert.DeserializeObject<T>(JObject.Parse(response).ToString());
        }

        protected async Task<T> DeleteAsync<T>(string url)
        {
            string response = await DeleteJsonRequest(url);
            return JsonConvert.DeserializeObject<T>(JObject.Parse(response).ToString());
        }

        public async Task<string> GetJsonRequestAsync(string url)
        {
            try
            {
                HttpResponseMessage response = await HttpClient.GetAsync(url).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            catch (HttpRequestException ex)
            {
                throw new UnauthorizedAccessException(ex.Message, ex);
            }
        }

        private async Task<string> PostJsonRequestAsync(string url, IEnumerable<KeyValuePair<string, string>> parameters)
        {
            var requestContent = new FormUrlEncodedContent(parameters);
            HttpResponseMessage response = await HttpClient.PostAsync(url, requestContent);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        protected async Task<string> DeleteJsonRequest(string url)
        {
            try
            {
                HttpResponseMessage response = await HttpClient.DeleteAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                throw new UnauthorizedAccessException(ex.Message, ex);
            }
        }
    }
}
