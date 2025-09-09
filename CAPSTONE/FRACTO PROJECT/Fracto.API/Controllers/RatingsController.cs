using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Fracto.API.Data;
using Fracto.API.Models;
using System.Security.Claims;
using Fracto.API.Models.Dtos;

[ApiController]
[Route("api/[controller]")]
public class RatingsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public RatingsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Ratings - Admin only
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<IEnumerable<Rating>>> GetRatings()
    {
        return await _context.Ratings
            .Include(r => r.Doctor)
            .Include(r => r.User)
            .ToListAsync();
    }

    // GET: api/Ratings/doctor/1 - Public
    [HttpGet("doctor/{doctorId}")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<Rating>>> GetRatingsByDoctor(int doctorId)
    {
        return await _context.Ratings
            .Include(r => r.User)
            .Where(r => r.DoctorId == doctorId)
            .ToListAsync();
    }

    // GET: api/Ratings/my - User’s own ratings
    // Use "User" with capital U to match tokens (case sensitive)
    [HttpGet("my")]
    [Authorize(Roles = "User")]
    public async Task<ActionResult<IEnumerable<Rating>>> GetMyRatings()
    {
        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        return await _context.Ratings
            .Include(r => r.Doctor)
            .Where(r => r.UserId == userId)
            .ToListAsync();
    }

    // POST: api/Ratings - User adds rating
    [HttpPost]
    [Authorize(Roles = "User")]
    public async Task<ActionResult<Rating>> PostRating(CreateRatingDto dto)
    {
        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        var rating = new Rating
        {
            DoctorId = dto.DoctorId,
            RatingValue = dto.RatingValue,
            UserId = userId
        };

        _context.Ratings.Add(rating);
        await _context.SaveChangesAsync();

        await UpdateDoctorAverage(dto.DoctorId);

        return CreatedAtAction(nameof(GetRatingsByDoctor), new { doctorId = dto.DoctorId }, rating);
    }

    // PUT: api/Ratings/5 - User updates own rating
    [HttpPut("{id}")]
    [Authorize(Roles = "User")]
    public async Task<IActionResult> PutRating(int id, UpdateRatingDto dto)
    {
        var rating = await _context.Ratings.FindAsync(id);
        if (rating == null) return NotFound();

        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        if (rating.UserId != userId) return Forbid();

        rating.RatingValue = dto.RatingValue;
        _context.Entry(rating).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        await UpdateDoctorAverage(rating.DoctorId);

        return NoContent();
    }

    // DELETE: api/Ratings/5 - Admin only
    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteRating(int id)
    {
        var rating = await _context.Ratings.FindAsync(id);
        if (rating == null) return NotFound();

        var doctorId = rating.DoctorId;

        _context.Ratings.Remove(rating);
        await _context.SaveChangesAsync();

        await UpdateDoctorAverage(doctorId);

        return NoContent();
    }

    // 🔧 Helper to recalc doctor’s average
    private async Task UpdateDoctorAverage(int doctorId)
    {
        var doctor = await _context.Doctors.FindAsync(doctorId);
        if (doctor != null)
        {
            var ratings = await _context.Ratings
                .Where(r => r.DoctorId == doctorId)
                .ToListAsync();

            doctor.Rating = ratings.Any() ? (decimal)ratings.Average(r => r.RatingValue) : 0;
            _context.Entry(doctor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
