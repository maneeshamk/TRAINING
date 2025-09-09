namespace Fracto.API.Models.DTOs
{
    public class UpdateAppointmentDto
    {
        public int AppointmentId { get; set; }
        public int? DoctorId { get; set; }   // Admins can change doctor
        public DateTime AppointmentDate { get; set; }
        public string TimeSlot { get; set; } = string.Empty;
        public string? Status { get; set; }  // e.g., Booked, Cancelled, Completed
    }
}
