using DAO.BaseModels;
using DAO.Context;
using DAO.Reposistories_Impl;
using DAO.Repositories;
using DesktopApp.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using Services.Services_Impl;
using Services.Thingsboard_Services;

namespace DesktopApp;

static class Program
{
    public static ServiceProvider? ServiceProvider { get; private set; }
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        ServiceProvider = serviceCollection.BuildServiceProvider();

        ApplicationConfiguration.Initialize();
        var mainForm = ServiceProvider.GetRequiredService<MainForm>();
        Application.Run(mainForm);
    }

    static void ConfigureServices(IServiceCollection services)
    {
        var connectionString = "Server=localhost;Database=SmartHome;User Id=sa;Password=P@ssw0rd";
        services.AddLogging();
        services.AddSingleton<IHttpContextAccessor, CustomHttpContextAccessor>();

        //add dbcontext
        services.AddDbContext<SmartHomeContext>(options =>
    options.UseSqlServer(connectionString));

        services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<SmartHomeContext>()
            .AddDefaultTokenProviders();

        services.Configure<IdentityOptions>(options =>
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

        services.ConfigureApplicationCookie(options =>
        {
            options.Cookie.HttpOnly = true;
            options.ExpireTimeSpan = TimeSpan.FromDays(150);
            options.SlidingExpiration = true;
        });        //add repositories
        services.AddSingleton<IDeviceRepository, DeviceRepository>();
        services.AddSingleton<IRoomRepository, RoomRepository>();
        services.AddSingleton<IUserRepository, UserRepository>();
        services.AddSingleton<IHouseRepository, HouseRepository>();
        //add services
        services.AddSingleton<IDeviceService, DeviceService>();
        services.AddSingleton<IRoomService, RoomService>();
        services.AddSingleton<IUserService, UserService>();
        services.AddSingleton<IHouseService, HouseService>();
        services.AddSingleton<IThingsboardService, ThingsboardService>();
        services.AddSingleton<SignInManager<User>>();
        services.AddSingleton<UserManager<User>>();
        services.AddSingleton<RoleManager<IdentityRole>>();
        //add views
        services.AddScoped<Login>();
        services.AddScoped<SignUp>();
        services.AddScoped<MainForm>();
        services.AddScoped<DashBoard>();
        //add service 

    }
}