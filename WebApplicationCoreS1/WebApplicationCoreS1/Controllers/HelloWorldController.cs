using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text.Encodings.Web;


namespace WebApplicationCoreS1.Controllers
{
    public class HelloWorldController : Controller
    {
        /*public string Index()
        {
            return "This is my default action...";
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
        }*/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
    
}
