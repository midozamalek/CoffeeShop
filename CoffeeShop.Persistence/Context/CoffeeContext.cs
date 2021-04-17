using CoffeeShop.Infrastructure.Entities;
using CoffeeShop.Infrastructure.Enums;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
 
using System.Threading.Tasks;
using CoffeeShop.Infrastructure.Extensions;

namespace CoffeeShop.Persistence.Context
{
    public class CoffeeContext : DbContext
    {
        private string _connectionString;

        public virtual DbSet<CoffeeFlavor> CoffeeFlavors { get; set; }
        public virtual DbSet<CoffeeMachine> CoffeeMachines { get; set; }
        public virtual DbSet<CoffeePod> CoffeePods { get; set; }
        public virtual DbSet<ModelType> ModelTypes { get; set; }
        public virtual DbSet<PackSize> PackSizes { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }

        public CoffeeContext()
        {
        }

        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            var modelTypes = CoffeeContextSeed.GetPreconfiguredModelTypes();
            modelBuilder.Entity<ModelType>().HasData(modelTypes.ToArray());


            var coffeeFlavors = CoffeeContextSeed.GetPreconfiguredCoffeeFlavors();
            modelBuilder.Entity<CoffeeFlavor>().HasData(coffeeFlavors.ToArray());

            var packSizes = CoffeeContextSeed.GetPreconfiguredPackSizes();
            modelBuilder.Entity<PackSize>().HasData(packSizes.ToArray()) ;


            var productTypes = CoffeeContextSeed.GetPreconfiguredProductTypes();
            modelBuilder.Entity<ProductType>().HasData(productTypes.ToArray());

            modelBuilder.Entity<CoffeeMachine>().HasData(CoffeeContextSeed.GetPreconfiguredCoffeeMachines(productTypes,modelTypes).ToArray());

            modelBuilder.Entity<CoffeePod>().HasData(CoffeeContextSeed.GetPreconfiguredCoffeePods(productTypes,packSizes,coffeeFlavors).ToArray());


        }

        public CoffeeContext(DbContextOptions<CoffeeContext> options)
            : base(options)
        {
        }
       
    }
}
