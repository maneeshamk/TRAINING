// Models/Doctor.cs
using System.ComponentModel.DataAnnotations.Schema;

namespace Fracto.API.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        
        [ForeignKey("Specialization")]
        public int SpecializationId { get; set; }
        
        public string City { get; set; }
        public decimal Rating { get; set; }
        
        // Navigation property
        public Specialization Specialization { get; set; }
    }
}