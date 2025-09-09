using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Fracto.API.Data;
using Fracto.API.Models;
using Fracto.API.Models.DTOs;

[ApiController]
[Route("api/[controller]")]
public class DoctorsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public DoctorsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Doctors - Public endpoint (no authentication required)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctors()
    {
        return await _context.Doctors
            .Include(d => d.Specialization)
            .ToListAsync();
    }

    // GET: api/Doctors/5 - Public endpoint
    [HttpGet("{id}")]
    public async Task<ActionResult<Doctor>> GetDoctor(int id)
    {
        var doctor = await _context.Doctors
            .Include(d => d.Specialization)
            .FirstOrDefaultAsync(d => d.DoctorId == id);
        
        if (doctor == null) return NotFound();
        return doctor;
    }

    // GET: api/Doctors/specialization/1 - Public endpoint
    [HttpGet("specialization/{specializationId}")]
    public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctorsBySpecialization(int specializationId)
    {
        return await _context.Doctors
            .Include(d => d.Specialization)
            .Where(d => d.SpecializationId == specializationId)
            .ToListAsync();
    }

    // GET: api/Doctors/city/NewYork - Public endpoint
    [HttpGet("city/{city}")]
    public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctorsByCity(string city)
    {
        return await _context.Doctors
            .Include(d => d.Specialization)
            .Where(d => d.City.ToLower() == city.ToLower())
            .ToListAsync();
    }

    // POST: api/Doctors - Add doctor (Admin only)
    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Doctor>> PostDoctor(CreateDoctorDto dto)
    {
        var doctor = new Doctor
        {
            Name = dto.Name,
            SpecializationId = dto.SpecializationId,
            City = dto.City,
            Rating = dto.Rating
        };

        _context.Doctors.Add(doctor);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetDoctor), new { id = doctor.DoctorId }, doctor);
    }

    // PUT: api/Doctors/5 - Update doctor (Admin only)
    [HttpPut("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> PutDoctor(int id, Doctor doctor)
    {
        if (id != doctor.DoctorId)
            return BadRequest();

        _context.Entry(doctor).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/Doctors/5 - Delete doctor (Admin only)
    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteDoctor(int id)
    {
        var doctor = await _context.Doctors.FindAsync(id);
        if (doctor == null) return NotFound();

        _context.Doctors.Remove(doctor);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}

// DTO for creating doctors
public class CreateDoctorDto
{
    public string Name { get; set; }
    public int SpecializationId { get; set; }
    public string City { get; set; }
    public int Rating { get; set; } = 0;
}
