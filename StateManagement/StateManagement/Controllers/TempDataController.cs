using Microsoft.AspNetCore.Mvc;

namespace StateManagement.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult First()
        {
            TempData["UserID"] = 101;
            return View();
        }
        public IActionResult Second()
        {
            var userID = TempData["UserId"] ?? null;
            return View();
        }
        public IActionResult Third()
        {
            var userID = TempData["UserId"] ?? null;
            return View();
        }
    }
}
