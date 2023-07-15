using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreS1.Models;   //natra error aauxa."WebUser" model pani directive bata pass garnu paryo


namespace WebApplicationCoreS1.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult SimpleBinding()
		{
			return View(new WebUser() { FirstName = "Biplav", LastName= "Poudel"});
		}

		[HttpPost]      //notice action verb here: HttpPost
		public IActionResult SimpleBinding(WebUser webUser)
		{
			return Content($"User {webUser.FirstName} updated!");
		}
	}
}
