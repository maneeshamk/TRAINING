
namespace Fracto.API.Models.DTOs
{


    public class CreateDoctorDto
{
    public string Name { get; set; }
    public int SpecializationId { get; set; }
    public string City { get; set; }
    public int Rating { get; set; } = 0;
}

}