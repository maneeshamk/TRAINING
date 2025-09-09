// Models/DTOs/CreateAppointmentDto.cs
using System.ComponentModel.DataAnnotations;

namespace Fracto.API.Models.DTOs
{
    public class CreateAppointmentDto
    {
        [Required]
        public int DoctorId { get; set; }
        
        [Required]
        public DateTime AppointmentDate { get; set; }
        
        [Required]
        [StringLength(50)]
        public string TimeSlot { get; set; }
    }
}