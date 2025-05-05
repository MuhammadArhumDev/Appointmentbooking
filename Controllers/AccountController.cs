using Microsoft.AspNetCore.Mvc;

namespace AppointmentBookingSystem.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Signup()
        {
            return View();
        }
       
        public IActionResult Login()
        {
            return View();
        }
    }
}
