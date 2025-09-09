namespace Fracto.API.Models.Dtos
{
    public class CreateRatingDto
    {
        public int DoctorId { get; set; }
        public int RatingValue { get; set; }
    }

    public class UpdateRatingDto
    {
        public int RatingValue { get; set; }
    }
}
