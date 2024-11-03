using DAO.BaseModels;
using DAO.Context;
using DAO.Reposistories_Impl;
using DAO.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using Services.Services_Impl;
using System.Security.Claims;

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
            services.AddHttpContextAccessor();
            services.AddScoped<SmartHomeContext>();
            services.AddScoped<SignInManager<User>>();
            services.AddScoped<UserManager<User>>();
         
            // add repo services
            services.AddScoped<IUserRepository, UserRepository>();


            services.AddScoped<IUserService, UserService>();
            


            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<SmartHomeContext>()
                .AddDefaultTokenProviders();
            // Đăng ký form chính
            services.AddTransient<MainForm>();
        }
       
    }

}