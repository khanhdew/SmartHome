using DAO.BaseModels;
using DAO.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace DesktopApp
{
    internal static class Program
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
        private static void ConfigureServices(IServiceCollection services)
        {
            // Đăng ký các dịch vụ (Service Layer) và repository (Data Access Layer)
            // services.AddScoped<IUserService, UserService>();
            services.AddLogging();
            services.AddScoped<SmartHomeContext>();
            services.AddScoped<SignInManager<User>>();
            services.AddScoped<UserManager<User>>();

            
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<SmartHomeContext>()
                .AddDefaultTokenProviders();
            // Đăng ký form chính
            services.AddTransient<MainForm>();
        }
    }
}