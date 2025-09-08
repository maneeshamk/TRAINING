using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using myrazorapp.Data;

var builder = WebApplication.CreateBuilder(args);

// --- Default Connection for Identity ---
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
        options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// --- New Connection for EcomContext (Category & Product tables) ---
builder.Services.AddDbContext<EcomContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EcomConnectionString")));

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();   // ? Needed for Identity
app.UseAuthorization();

app.MapRazorPages();

app.Run();
