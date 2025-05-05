using Microsoft.AspNetCore.Mvc;

namespace AppointmentBookingSystem.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult AppointmentHistory()
        {
            return View();
        }

        public IActionResult FeedbackAndRating()
        {
            return View();
        }

        public IActionResult PersonalInformation()
        {
            return View();
        }

        public IActionResult UpcomingBookings()
        {
            return View();
        }
    }
}
