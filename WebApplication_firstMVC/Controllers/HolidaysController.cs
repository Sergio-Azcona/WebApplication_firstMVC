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
            if (string.IsNullOrEmpty(countryCode) && int.)
            {
                return View();
            }
            else
            {
                // check to see if year and countryCode are null

                //year = 2023;
                //countryCode = "us";
                //ViewBag["CountryCode"] = countryCode;
                //ViewBag["Year"] = year;
                countryCode = countryCode.ToLower();
                List<Holiday> holidays = new List<Holiday>();
                holidays = await _holidayService.GetHolidays(year, countryCode);

                var nationalHolidays = holidays.Where(holiday => holiday.National == true).ToList();

                //if (nationalHolidays.Count > 0)
                //{
                    return View(nationalHolidays);
                //}

            }

            //else
            //{
            //    return View();
            //}

        }
    }
}