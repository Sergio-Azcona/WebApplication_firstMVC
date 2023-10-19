 using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace WebApplication_firstMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name)
        {
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            return HtmlEncoder.Default.Encode($"Hello, {name}! This is the Welcome action method. Your ID is {ID}"); 
                //$(".... The numTimes is: {numTimes}");
        }
    }
}