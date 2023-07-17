using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreS1.Models;

namespace WebApplicationCoreS1.Controllers
{
	public class ValidationController : Controller
	{

		public IActionResult Index(WebUser webUser)
		{
			//var webUser = TempData["WebUser"] as WebUser;
			if (webUser == null)
			{
				return RedirectToAction("Index", "User");
			}

			return View(webUser);
		}

		[HttpPost]
		public IActionResult ProcessForm(WebUser webUser)
		{
			if (ModelState.IsValid)
			{
				return Content("Form data validated!");
			}
			else
			{
				//ModelState.AddModelError("", "An error occurred.");
				return Content("Form data not validated! Please enter again!");
			}
		}
	}
}
