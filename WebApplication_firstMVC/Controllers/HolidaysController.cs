using Microsoft.AspNetCore.Mvc;
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
            // check to see if year and countryCode are null

            year = 2023;
            countryCode = "us";
            //countryCode = countryCode.ToLower();
            List<Holiday> holidays = new List<Holiday>();
            holidays = await _holidayService.GetHolidays(year, countryCode);


            return View(holidays);
        }
    }
}