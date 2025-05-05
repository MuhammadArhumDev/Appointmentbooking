using Microsoft.AspNetCore.Mvc;

namespace AppointmentBookingSystem.Controllers
{
    public class ServicesFindController : Controller
    {
        public IActionResult BookAppointments()
        {
            return View();
        }
    }
}
