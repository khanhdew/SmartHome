using DAO.BaseModels;
using DAO.Reposistories_Impl;
using DAO.Repositories;
using DAO.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Services.Services_Impl;
using Services.Services;
using Microsoft.EntityFrameworkCore;
using Services.Thingsboard_Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SmartHomeContextConnection") ?? throw new InvalidOperationException("Connection string 'SmartHomeContextConnection' not found.");

builder.Services.AddDbContext<SmartHomeContext>(options =>
    options.UseSqlServer(connectionString));

// Register Identity services
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<SmartHomeContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;
    options.Password.RequiredUniqueChars = 1;

    // Lockout settings
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-.@+";
    options.User.RequireUniqueEmail = true;

    // Sign-in settings
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
});

// builder.Services.AddAuthentication().AddGoogle(
//     options =>
//     {
//         options.ClientId = builder.Configuration["Google:ClientId"];
//         options.ClientSecret = builder.Configuration["Google:ClientSecret"];
//         options.CallbackPath = "/signin-google";
//     });

builder.Services.AddAuthentication().AddGoogle(
    options =>
    {
        options.ClientId = "1052818535998-29qp83oac8fok6u25dmo3eteeirap0al.apps.googleusercontent.com";
        options.ClientSecret = "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";
        options.CallbackPath = "/signin-google";
    });

// Configure Authentication with both Cookie and JWT
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddCookie(options =>
{
    options.LoginPath = "/Login";
    options.LogoutPath = "/Logout";
    options.AccessDeniedPath = "/AccessDenied";
})
.AddJwtBearer("Bearer", options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

// Add other services
builder.Services.AddScoped<SmartHomeContext>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<SignInManager<User>>();
builder.Services.AddScoped<UserManager<User>>();
builder.Services.AddScoped<IHouseRepository, HouseRepository>();
builder.Services.AddScoped<IHouseService, HouseService>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();
builder.Services.AddScoped<IDeviceService, DeviceService>();
builder.Services.AddScoped<IThingsboardService, ThingsboardService>();



// Add MVC services
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDistributedMemoryCache();

// Add API Controllers
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline

app.UseExceptionHandler("/Error/GeneralError");
app.UseStatusCodePagesWithReExecute("/Error/{0}");

using (var scope = app.Services.CreateScope())
{
    var service = scope.ServiceProvider;
    DbInitializer.Initializer(service);
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=House}/{action=Index}");

// Map API routes
app.MapControllers();

app.Run();