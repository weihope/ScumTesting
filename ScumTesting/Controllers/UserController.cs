using Microsoft.AspNetCore.Mvc;

namespace ScumTesting.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
