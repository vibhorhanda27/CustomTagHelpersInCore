using Microsoft.AspNetCore.Mvc;

namespace CustomHelpers.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
