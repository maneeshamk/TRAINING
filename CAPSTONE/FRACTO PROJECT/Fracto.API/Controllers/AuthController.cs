// Controllers/AuthController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Fracto.API.Data;
using Fracto.API.Models;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IConfiguration _configuration;

    public AuthController(ApplicationDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    // POST: api/Auth/register - Public endpoint (no authentication required)
    [HttpPost("register")]
    public async Task<ActionResult<User>> Register(User user)
    {
        // Check if username already exists
        if (await _context.Users.AnyAsync(u => u.Username == user.Username))
            return BadRequest("Username already exists");

        // Normalize role casing ("User" / "Admin")
        user.Role = user.Role.Equals("admin", StringComparison.OrdinalIgnoreCase) ? "Admin" : "User";

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        
        var token = GenerateJwtToken(user);
        return Ok(new { message = "Registration successful", user, token });
    }

    // POST: api/Auth/login - Public endpoint (no authentication required)
    [HttpPost("login")]
    public async Task<ActionResult<User>> Login(LoginRequest request)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Username == request.Username && u.Password == request.Password);
        
        if (user == null)
            return Unauthorized("Invalid username or password");

        // Normalize role casing ("User" / "Admin")
        user.Role = user.Role.Equals("admin", StringComparison.OrdinalIgnoreCase) ? "Admin" : "User";

        var token = GenerateJwtToken(user);
        return Ok(new { message = "Login successful", user, token });
    }

    private string GenerateJwtToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
        
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role) // Always "User" or "Admin"
            }),
            Expires = DateTime.UtcNow.AddHours(2),
            Issuer = _configuration["Jwt:Issuer"],
            Audience = _configuration["Jwt:Audience"],
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
