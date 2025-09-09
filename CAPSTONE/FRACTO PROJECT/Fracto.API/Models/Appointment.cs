// Models/Appointment.cs
using System.ComponentModel.DataAnnotations.Schema;

namespace Fracto.API.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        
        [ForeignKey("User")]
        public int UserId { get; set; }
        
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        
        public DateTime AppointmentDate { get; set; }
        public string TimeSlot { get; set; }
        public string Status { get; set; }
        
        // Navigation properties
        public User User { get; set; }
        public Doctor Doctor { get; set; }
    }
}