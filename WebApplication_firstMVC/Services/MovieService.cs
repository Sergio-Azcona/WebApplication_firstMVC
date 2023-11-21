using System.Net;
using WebApplication_firstMVC.Models;

namespace WebApplication_firstMVC.Services
{
    public class MovieService
    {

        private static HttpClient CreateHttpClient()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://api.themoviedb.org")
            };

            //client check with the server if it's acceptable to send a payload before actually sending it
            ServicePointManager.Expect100Continue = true;
            //communication between the client and server is conducted using a secure protocol
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // clear defaiult HTTP headers
            client.DefaultRequestHeaders.Clear();
            // add header of preferred response type, ie json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

            public static async Task<List<Movie>> SearchMoviesAsync(string title, string language, string year = null)
        {
            var queryParams = new List<KeyValuePair<string, string>>();

            //evaluate params and include them int the query string if not null/empty
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Movie Name Required", nameof(title));
            }
            else
            {
                queryParams.Add(new KeyValuePair<string, string>("query", title));
            }

            if (!string.IsNullOrEmpty(language))
            {
                queryParams.Add(new KeyValuePair<string, string>("language", language));
            }

            if (year != null)
            {
                queryParams.Add(new KeyValuePair<string, string>("year", year));
            }

            queryParams.Add(new KeyValuePair<string, string>("api_key", "cdfa0ca10aec931ced68ddcdb21b6b32"));

            string queryParamString = string.Join("&", queryParams.Select(kv => $"{kv.Key}={Uri.EscapeDataString(kv.Value)}"));

            // Build the complete URL
            string url = $"/3/search/movie?{queryParamString}";

            using (HttpClient client = CreateHttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Movie>>();
                }
                else
                {
                    throw new HttpRequestException($"Request failed with status code {response.StatusCode}");
                }
            }
        }
    }
}
