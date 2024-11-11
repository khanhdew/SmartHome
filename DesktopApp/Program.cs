using DAO.BaseModels;
using DAO.Context;
using DAO.Reposistories_Impl;
using DAO.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Services.Services_Impl;
using Services.Services;
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
        services.AddLogging();
        services.AddHttpContextAccessor();
        //add repositories
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
        
        services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<SmartHomeContext>()
            .AddDefaultTokenProviders();
        
        services.AddTransient<MainForm>();
    }
}