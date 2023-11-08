using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using WebApplication_firstMVC.Interfaces;
using WebApplication_firstMVC.Models;

namespace WebApplication_firstMVC.Services
{
    public class HolidayApiService : IHolidayService
    { 
        private static readonly HttpClient client;

        static HolidayApiService()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://date.nager.at")
            };
        }

        public async Task<List<Holiday>> GetHolidays(int year, string countryCode)
        {
            var url = string.Format($"api/v3/publicholidays/{year}/{countryCode}");
            var results = new List<Holiday>();
            var results1 = new List<Holiday>();
            var results2 = new List<Holiday>();
            var results3 = new List<Holiday>();

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var stringResponse =  await response.Content.ReadAsStringAsync();

                // deserializing syntex 
                results = JsonSerializer.Deserialize<List<Holiday>>(stringResponse);
           
                results1 = JsonSerializer.Deserialize<List<Holiday>>(stringResponse, JsonSerializerOptions.Default);

                // for PascalCase serialization"
                results2 = JsonSerializer.Deserialize<List<Holiday>>(stringResponse, 
                           new JsonSerializerOptions() { PropertyNamingPolicy = null } );

                // use the following code if i did NOT use JsonPropertyName in model; this is for camelCase serialization:
                //results3 = JsonSerializer.Deserialize<List<HolidayModel>>(stringResponse,
                //        new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase); 
            }

            return results;
        }

        //public async Task<List<Holiday>> GetLongWeekends(int year, string countryCode)
        //{
        //    var url = string.Format($"/api/v3/LongWeekend/{year}/{countryCode}");
        //    var results = new List<Holiday>();
        //    var response = await client.GetAsync(url);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var stringResponse = await response.Content.ReadAsStringAsync();

        //        results = JsonSerializer.Deserialize<List<Holiday>>(stringResponse);
        //    }
        //    else
        //    {
        //        throw new HttpRequestException(response.ReasonPhrase);
        //    }

        //    return results;

        //}

        //public async Task<List<Holiday>> GetInternationalHolidays()
        //{
        //    var url = string.Format($"/api/v3/NextPublicHolidaysWorldwide");
        //    var results = new List<Holiday>();
        //    var response = await client.GetAsync(url);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var stringResponse = await response.Content.ReadAsStringAsync();

        //        results = JsonSerializer.Deserialize<List<Holiday>>(stringResponse);
        //    }
        //    else
        //    {
        //        throw new HttpRequestException(response.ReasonPhrase);
        //    }

        //    return results;

        //}

    }
}
