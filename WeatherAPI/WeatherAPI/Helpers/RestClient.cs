using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAPI.Helpers
{
    public class RestClient
    {
        private static HttpClient GetClient(string baseUrl)
        {
            var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        private static async Task<T> ProcessResponse<T>(HttpResponseMessage response) where T : class
        {
            T result = null;
            await response.Content.ReadAsStringAsync().ContinueWith(x =>
            {
                if (x.IsFaulted)
                    throw x.Exception ?? new Exception("Something goes wrong during reading of the REST response");

                result = JsonConvert.DeserializeObject<T>(x.Result);
            });
            return result;
        }

        public static async Task<T> GetAsync<T>(RestUrl api) where T : class
        {
            using (var client = GetClient(api.Base))
            {
                var response = await client.GetAsync(api.Route).ConfigureAwait(false);

                response.EnsureSuccessStatusCode();

                return await ProcessResponse<T>(response);
            }
        }
    }
}