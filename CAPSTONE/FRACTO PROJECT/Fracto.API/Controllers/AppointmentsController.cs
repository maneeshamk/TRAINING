using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Fracto.API.Data;
using Fracto.API.Models;
using Fracto.API.Models.DTOs;
using System.Security.Claims;

[ApiController]
[Route("api/[controller]")]
public class AppointmentsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AppointmentsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Appointments - Admin only
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<IEnumerable<Appointment>>> GetAppointments()
    {
        return await _context.Appointments
            .Include(a => a.User)
            .Include(a => a.Doctor)
            .ThenInclude(d => d.Specialization)
            .ToListAsync();
    }

    // GET: api/Appointments/5 - User can see their own, Admin can see all
    [HttpGet("{id}")]
    [Authorize(Roles = "User,Admin")]
    public async Task<ActionResult<Appointment>> GetAppointment(int id)
    {
        var appointment = await _context.Appointments
            .Include(a => a.User)
            .Include(a => a.Doctor)
            .ThenInclude(d => d.Specialization)
            .FirstOrDefaultAsync(a => a.AppointmentId == id);

        if (appointment == null) return NotFound();

        var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        var currentUserRole = User.FindFirst(ClaimTypes.Role)?.Value;

        if (currentUserRole != "Admin" && appointment.UserId != currentUserId)
            return Forbid();

        return appointment;
    }

    // GET: api/Appointments/user/1 - User can see their own, Admin can see any user's
    [HttpGet("user/{userId}")]
    [Authorize(Roles = "User,Admin")]
    public async Task<ActionResult<IEnumerable<Appointment>>> GetAppointmentsByUser(int userId)
    {
        var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        var currentUserRole = User.FindFirst(ClaimTypes.Role)?.Value;

        if (currentUserRole != "Admin" && userId != currentUserId)
            return Forbid();

        return await _context.Appointments
            .Include(a => a.Doctor)
            .ThenInclude(d => d.Specialization)
            .Where(a => a.UserId == userId)
            .ToListAsync();
    }

    // POST: api/Appointments - Users can book appointments
    [HttpPost]
    [Authorize(Roles = "User")]
    public async Task<ActionResult<Appointment>> PostAppointment(CreateAppointmentDto appointmentDto)
    {
        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        var appointment = new Appointment
        {
            UserId = userId,
            DoctorId = appointmentDto.DoctorId,
            AppointmentDate = appointmentDto.AppointmentDate,
            TimeSlot = appointmentDto.TimeSlot,
            Status = "Booked"
        };

        _context.Appointments.Add(appointment);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetAppointment), new { id = appointment.AppointmentId }, appointment);
    }

    // ✅ NEW: PUT: api/Appointments/5 - Update appointment
    [HttpPut("{id}")]
    [Authorize(Roles = "User,Admin")]
    public async Task<IActionResult> PutAppointment(int id, UpdateAppointmentDto dto)
    {
        var appointment = await _context.Appointments.FindAsync(id);
        if (appointment == null) return NotFound();

        var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        var currentUserRole = User.FindFirst(ClaimTypes.Role)?.Value;

        if (currentUserRole != "Admin" && appointment.UserId != currentUserId)
            return Forbid();

        appointment.AppointmentDate = dto.AppointmentDate;
        appointment.TimeSlot = dto.TimeSlot;
        appointment.Status = dto.Status ?? appointment.Status;

        if (dto.DoctorId.HasValue && currentUserRole == "Admin")
            appointment.DoctorId = dto.DoctorId.Value;

        _context.Entry(appointment).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // PUT: api/Appointments/5/cancel
    [HttpPut("{id}/cancel")]
    [Authorize(Roles = "User,Admin")]
    public async Task<IActionResult> CancelAppointment(int id)
    {
        var appointment = await _context.Appointments.FindAsync(id);
        if (appointment == null) return NotFound();

        var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        var currentUserRole = User.FindFirst(ClaimTypes.Role)?.Value;

        if (currentUserRole != "Admin" && appointment.UserId != currentUserId)
            return Forbid();

        appointment.Status = "Cancelled";
        _context.Entry(appointment).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
