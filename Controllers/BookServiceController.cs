using Microsoft.AspNetCore.Mvc;

namespace AppointmentBookingSystem.Controllers
{
    public class BookServiceController : Controller
    {
        public IActionResult SelectSlot()
        {
            return View();
        }

        public IActionResult ServiceDetails()
        {
            return View();
        }
    }
}
