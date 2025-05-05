using Microsoft.AspNetCore.Identity;

namespace AppointmentBookingSystem.Models
{
    public class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password{get; set; }
        public string username { get; set; }
        public string role { get; set; }
        public string address { get; set; }
        public string bio { get; set; }

        public string services { get; set; }
        public string rating { get; set; }

    }
}
