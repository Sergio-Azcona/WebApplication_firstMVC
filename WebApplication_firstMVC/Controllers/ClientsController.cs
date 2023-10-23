using Microsoft.AspNetCore.Mvc;

namespace WebApplication_firstMVC.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
