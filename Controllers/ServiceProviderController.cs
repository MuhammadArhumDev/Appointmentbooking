using Microsoft.AspNetCore.Mvc;

namespace AppointmentBookingSystem.Controllers
{
    public class ServiceProviderController : Controller
    {
        public IActionResult BusinessInformation()
        {
            return View();
        }


        public IActionResult ManageAvailability()
        {
            return View();
        }

        public IActionResult OfferedServices()
        {
            return View();
        }


        public IActionResult UpcomingAppointments()
        {
            return View();
        }
    }
}
