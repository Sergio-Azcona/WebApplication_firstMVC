using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication_firstMVC.Models;

namespace WebApplication_firstMVC.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}