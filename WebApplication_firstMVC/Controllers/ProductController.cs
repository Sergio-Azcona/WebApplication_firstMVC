using System;
// using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            throw new NotImplementedException();
        }

        public ActionResult Details(int Id)
        {
            return View("Details");
        }
    }
}
