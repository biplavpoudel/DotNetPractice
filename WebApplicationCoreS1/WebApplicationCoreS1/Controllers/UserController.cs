using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreS1.Models;   //natra error aauxa."WebUser" model pani directive bata pass garnu paryo


namespace WebApplicationCoreS1.Controllers
{
	public class UserController : Controller
	{

		public IActionResult Index()
		{
			return View(new WebUser() { FirstName = "Biplav", LastName= "Poudel", MailAddress="biplavpoudel764@gmail.com"});
		}


	//eutai route bata form data farkinxa so we are using the same action, albiet with a WebUser object as args
		[HttpPost]      //notice action verb here: HttpPost
		public IActionResult SubmitForm(WebUser webUser)
		{
			return RedirectToAction("Index", "Validation", webUser);
		}
	}
}
