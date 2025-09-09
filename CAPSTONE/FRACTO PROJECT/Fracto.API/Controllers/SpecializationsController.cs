using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Fracto.API.Data;
using Fracto.API.Models;

[ApiController]
[Route("api/[controller]")]
public class SpecializationsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public SpecializationsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Specializations - Public endpoint (no authentication required)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Specialization>>> GetSpecializations()
    {
        return await _context.Specializations.ToListAsync();
    }

    // GET: api/Specializations/5 - Public endpoint
    [HttpGet("{id}")]
    public async Task<ActionResult<Specialization>> GetSpecialization(int id)
    {
        var specialization = await _context.Specializations.FindAsync(id);
        if (specialization == null) return NotFound();
        return specialization;
    }

    // POST: api/Specializations - Add specialization (Admin only)
    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Specialization>> PostSpecialization(Specialization specialization)
    {
        _context.Specializations.Add(specialization);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetSpecialization), new { id = specialization.SpecializationId }, specialization);
    }

    // PUT: api/Specializations/5 - Update specialization (Admin only)
    [HttpPut("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> PutSpecialization(int id, Specialization specialization)
    {
        if (id != specialization.SpecializationId)
            return BadRequest();

        _context.Entry(specialization).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/Specializations/5 - Delete specialization (Admin only)
    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteSpecialization(int id)
    {
        var specialization = await _context.Specializations.FindAsync(id);
        if (specialization == null) return NotFound();

        _context.Specializations.Remove(specialization);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
