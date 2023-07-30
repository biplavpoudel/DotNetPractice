using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;
using StateManagement.Models;

namespace StateManagement.Controllers
{
	public class WelcomeController : Controller
	{
		private readonly IHttpContextAccessor _contextAccessor;

		public WelcomeController(IHttpContextAccessor contextAccessor)
		{
			_contextAccessor = contextAccessor;
		}
		
		public IActionResult Index()
		{
			//adding a simple cookie using HttpContextAccessor
			var cookieOptions = new CookieOptions
			{
				Expires = DateTimeOffset.UtcNow.AddDays(1)
			};
			_contextAccessor.HttpContext.Response.Cookies.Append("MyCookie", "My Cookie Value", cookieOptions);

			HttpContext.Session.SetInt32("Id", 100);
			HttpContext.Session.SetString("Name", "John");
			HttpContext.Session.SetInt32("Age", 32);
			return View();
		}
		public IActionResult Get()
		{
			//to read the cookie
			string myCookieValue = _contextAccessor.HttpContext.Request.Cookies["MyCookie"];
			TempData["Cookies"] = myCookieValue;

			User u = new User()
			{
				Id = HttpContext.Session.GetInt32("Id").Value,
				Name = HttpContext.Session.GetString("Name"),
				Age = HttpContext.Session.GetInt32("Age").Value
			};
			return View(u);

		}

		[HttpGet]
		public IActionResult SetHiddenValue()
		{
			User newUser = new User()
			{
				Id = 101,
				Name = "Biplav",
				Age = 22
			};
			return View(newUser);
		}

		[HttpPost]
		public IActionResult SetHiddenValue(IFormCollection keyValues) {
			var id = keyValues["Id"];
			return View();
		}
	}
}

