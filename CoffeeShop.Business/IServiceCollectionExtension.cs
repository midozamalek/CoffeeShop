using CoffeeShop.Business.Services;
using CoffeeShop.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Business
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection RegisterBALServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterDALServices(configuration);

            services.AddScoped<ICoffeeService, CoffeeService>();

            return services;
        }
    }
}
