using System.Text.Json.Serialization;

namespace WebApplication_firstMVC.Models
{
    public class Holiday
    {
        public string? Name { get; set; }

        [JsonPropertyName("countryCode")]
        public string? Country { get; set; }

        [JsonPropertyName("global")]
        public bool? NationalHoliday { get; set; }

        public DateTime? Date { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? WeekendStartDate { get; set; }
        
        [JsonPropertyName("endDate")]
        public DateTime? WeekendEndDate { get; set; }
        
        [JsonPropertyName("dayCount")]
        public int? WeekendDayCount { get; set; }

        [JsonPropertyName("needBridgeDay")]
        public bool? WeekendNeedBridgeDay { get; set; }
    }
}
