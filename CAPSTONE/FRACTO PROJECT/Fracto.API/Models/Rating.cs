// Models/Rating.cs
using System.ComponentModel.DataAnnotations.Schema;

namespace Fracto.API.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        
        [ForeignKey("User")]
        public int UserId { get; set; }
        
        public int RatingValue { get; set; }
        
        // Navigation properties
        public Doctor Doctor { get; set; }
        public User User { get; set; }
    }
}