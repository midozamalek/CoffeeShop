using CoffeeShop.Infrastructure.Entities;
using CoffeeShop.Persistence.Context;
using CoffeeShop.Persistence.ReadRepository;
using CoffeeShop.Persistence.Specification;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Persistence
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection RegisterDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Sqlite");

            services.AddDbContext<CoffeeContext>(options =>
             options.UseSqlite(connectionString), ServiceLifetime.Scoped);

            var sp = services.BuildServiceProvider();

            var CoffeeContext = sp.GetService<CoffeeContext>();
            services.AddScoped<IReadRepository<CoffeeMachine>>(x =>
                                 new EfReadRepository<CoffeeMachine>(CoffeeContext));

            services.AddScoped<IReadRepository<CoffeePod>>(x =>
                                 new EfReadRepository<CoffeePod>(CoffeeContext));

            services.AddScoped<ISpecificationFactory, SpecificationFactory>();
            return services;
        }
    }
}
