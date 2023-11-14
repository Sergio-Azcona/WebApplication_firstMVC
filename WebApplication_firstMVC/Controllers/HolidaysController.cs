using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebApplication_firstMVC.Interfaces;
using WebApplication_firstMVC.Models;

namespace WebApplication_firstMVC.Controllers
{
    public class HolidaysController : Controller
    {
        
        private readonly IHolidayService _holidayService;

        public HolidaysController(IHolidayService holidayApiService)
        {
            _holidayService = holidayApiService;
        }
        public async Task<IActionResult> Index(int year, string countryCode)
        {
            if (string.IsNullOrEmpty(countryCode))
            {
                return View();
            }
            else
            {
                // to do: in View > form: add year drop down (from 1973 to present year - Desc? )

                countryCode = countryCode.ToLower();
                List<Holiday> holidays = new List<Holiday>();
                holidays = await _holidayService.GetHolidays(year, countryCode);

                var nationalHolidays = holidays.Where(holiday => holiday.National == true).ToList();

                return View(nationalHolidays);
            }

        }
    }
}