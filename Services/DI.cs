using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using DAO.Context;
namespace Services
{
    class DI
    {
        public static IServiceProvider? ServiceProvider { get; set; }

        public static void RegisterServices()
        {
            var services = new ServiceCollection();

            // Add services to the collection.
            services.AddScoped<DbContext>();

            // Build the IServiceProvider.
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
