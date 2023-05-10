using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
