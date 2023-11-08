using System.Text.Json.Serialization;

namespace WebApplication_firstMVC.Models
{
    public class Holiday
    {
        [JsonPropertyName("localName")]
        public string Name { get; set; }
        //public string LocalName { get; set; }
        [JsonPropertyName("date")]
        public DateTime? Date { get; set; }
        //public string CountryCode { get; set; }
        //public bool Global { get; set; }

        //public string? Name { get; set; }

        [JsonPropertyName("countryCode")]
        public string Country { get; set; }

        [JsonPropertyName("global")]
        public bool? National { get; set; }

        //public DateTime? Date { get; set; }

        //[JsonPropertyName("startDate")]
        //public DateTime? WeekendStartDate { get; set; }

        //[JsonPropertyName("endDate")]
        //public DateTime? WeekendEndDate { get; set; }

        //[JsonPropertyName("dayCount")]
        //public int? WeekendDayCount { get; set; }

        //[JsonPropertyName("needBridgeDay")]
        //public bool? WeekendNeedBridgeDay { get; set; }
    }
}
