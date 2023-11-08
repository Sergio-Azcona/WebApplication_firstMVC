using WebApplication_firstMVC.Models;

namespace WebApplication_firstMVC.Interfaces
{
    public interface IHolidayService
    {
        Task<List<Holiday>> GetHolidays(int year, string countryCode);

        //Task<List<Holiday>> GetLongWeekends(int year, string countryCode);

        //Task<List<Holiday>> GetInternationalHolidays();
    }
}