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
            var url = string.Format($"/api/v3/{year}/{countryCode}");
            var results = new List<Holiday>();
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var stringResponse =  await response.Content.ReadAsStringAsync();

                results = JsonSerializer.Deserialize<List<Holiday>>(stringResponse);
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase); 
            }

            return results;
        }

        public async Task<List<Holiday>> GetLongWeekends(int year, string countryCode)
        {
            var url = string.Format($"/api/v3/LongWeekend/{year}/{countryCode}");
            var results = new List<Holiday>();
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                results = JsonSerializer.Deserialize<List<Holiday>>(stringResponse);
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return results;

        }

        public async Task<List<Holiday>> GetInternationalHolidays()
        {
            var url = string.Format($"/api/v3/NextPublicHolidaysWorldwide");
            var results = new List<Holiday>();
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                results = JsonSerializer.Deserialize<List<Holiday>>(stringResponse);
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return results;

        }

    }
}
