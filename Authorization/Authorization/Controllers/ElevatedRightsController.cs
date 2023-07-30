using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authorization.Controllers
{
    [Authorize(Policy = "ElevatedRights")]
    public class ElevatedRightsController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is an elevated rights area. Only administrators, power users, and backup administrators have access.");
        }

    }
}
