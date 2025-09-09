// Controllers/UsersController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Fracto.API.Data;
using Fracto.API.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Security.Claims;

[ApiController]
[Route("api/[controller]")]
// ❌ REMOVE THIS: [Authorize(Roles = "Admin")] 
public class UsersController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IWebHostEnvironment _env;

    public UsersController(ApplicationDbContext context, IWebHostEnvironment env)
    {
        _context = context;
        _env = env;
    }

    // GET: api/Users - Admin only
    [HttpGet]
    [Authorize(Roles = "Admin")] // ✅ Add here instead
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }

    // GET: api/Users/5 - Admin or own user
    [HttpGet("{id}")]
    [Authorize]
    public async Task<ActionResult<User>> GetUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return NotFound();
        
        // Allow admin or the user themselves
        var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        var currentRole = User.FindFirst(ClaimTypes.Role)?.Value;
        
        if (currentRole != "Admin" && currentUserId != id)
            return Forbid();
            
        return user;
    }

    // POST: api/Users - Public (for registration)
    [HttpPost]
    [AllowAnonymous] // ✅ Allow anyone to register
    public async Task<ActionResult<User>> PostUser(User user)
    {
        if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            return BadRequest("Username and password are required.");

        if (await _context.Users.AnyAsync(u => u.Username == user.Username))
            return BadRequest("Username already exists.");

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user);
    }

    // PUT: api/Users/5 - Admin or own user
    [HttpPut("{id}")]
    [Authorize]
    public async Task<IActionResult> PutUser(int id, User user)
    {
        if (id != user.UserId) return BadRequest("ID mismatch.");

        var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        var currentRole = User.FindFirst(ClaimTypes.Role)?.Value;
        
        if (currentRole != "Admin" && currentUserId != id)
            return Forbid();

        var existing = await _context.Users.FindAsync(id);
        if (existing == null) return NotFound();

        existing.Username = user.Username;
        existing.Password = user.Password;
        existing.Role = user.Role;
        existing.ProfileImagePath = user.ProfileImagePath;

        _context.Entry(existing).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // PUT: api/Users/5/role - Admin only
    [HttpPut("{id}/role")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> ChangeRole(int id, [FromBody] RoleChangeDto dto)
    {
        if (dto == null || string.IsNullOrWhiteSpace(dto.Role))
            return BadRequest("Role is required.");

        var user = await _context.Users.FindAsync(id);
        if (user == null) return NotFound();

        user.Role = dto.Role;
        _context.Entry(user).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // DELETE: api/Users/5 - Admin only
    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return NotFound();

        if (!string.IsNullOrWhiteSpace(user.ProfileImagePath))
        {
            try
            {
                var fullOld = Path.Combine(_env.WebRootPath ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"),
                                           user.ProfileImagePath.Replace("/", Path.DirectorySeparatorChar.ToString()));
                if (System.IO.File.Exists(fullOld))
                {
                    System.IO.File.Delete(fullOld);
                }
            }
            catch { }
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // POST: api/Users/{id}/upload-avatar - Admin or own user
    [HttpPost("{id}/upload-avatar")]
    [Authorize]
    public async Task<IActionResult> UploadAvatar(int id, IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("No file uploaded.");

        var user = await _context.Users.FindAsync(id);
        if (user == null) return NotFound();

        var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        var currentRole = User.FindFirst(ClaimTypes.Role)?.Value;
        
        // ✅ Allow admin or the user themselves
        if (currentRole != "Admin" && currentUserId != id)
            return Forbid();

        var allowedExt = new[] { ".png", ".jpg", ".jpeg", ".gif" };
        var ext = Path.GetExtension(file.FileName).ToLowerInvariant();
        if (!allowedExt.Contains(ext))
            return BadRequest("Unsupported file type.");

        const long maxBytes = 2 * 1024 * 1024;
        if (file.Length > maxBytes)
            return BadRequest("File too large. Max 2 MB allowed.");

        var webRoot = _env.WebRootPath ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        var uploadsFolder = Path.Combine(webRoot, "uploads");
        if (!Directory.Exists(uploadsFolder)) Directory.CreateDirectory(uploadsFolder);

        var uniqueFileName = $"{Guid.NewGuid()}{ext}";
        var fullPath = Path.Combine(uploadsFolder, uniqueFileName);

        using (var stream = System.IO.File.Create(fullPath))
        {
            await file.CopyToAsync(stream);
        }

        if (!string.IsNullOrWhiteSpace(user.ProfileImagePath))
        {
            try
            {
                var oldFull = Path.Combine(webRoot, user.ProfileImagePath.Replace("/", Path.DirectorySeparatorChar.ToString()));
                if (System.IO.File.Exists(oldFull)) System.IO.File.Delete(oldFull);
            }
            catch { }
        }

        user.ProfileImagePath = Path.Combine("uploads", uniqueFileName).Replace("\\", "/");
        _context.Entry(user).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        var url = $"{Request.Scheme}://{Request.Host}/{user.ProfileImagePath}";
        return Ok(new { message = "Upload successful", url, relativePath = user.ProfileImagePath });
    }
}

public class RoleChangeDto
{
    public string Role { get; set; } = string.Empty;
}