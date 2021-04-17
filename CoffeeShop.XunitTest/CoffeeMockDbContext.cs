using CoffeeShop.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.XunitTest
{
    public class CoffeeMockDbContext
    {
        [Obsolete]
        public CoffeeMockDbContext()
        {
            var options = new DbContextOptionsBuilder<CoffeeContext>()
                .UseInMemoryDatabase()
                .Options;

            CoffeeContext = new CoffeeContext(options);

            MockData();
        }

        public CoffeeContext CoffeeContext { get; }

        public void Dispose()
        {
            CoffeeContext.Database.EnsureDeleted();
            CoffeeContext.Dispose();
            GC.SuppressFinalize(this);
        }

        private void MockData()
        {
            var modelTypes = CoffeeContextSeed.GetPreconfiguredModelTypes().ToArray();
            var coffeeFlavors = CoffeeContextSeed.GetPreconfiguredCoffeeFlavors().ToArray();
            var packSizes = CoffeeContextSeed.GetPreconfiguredPackSizes().ToArray();
            var productTypes = CoffeeContextSeed.GetPreconfiguredProductTypes().ToArray();

            CoffeeContext.AddRange(modelTypes);
            CoffeeContext.AddRange(coffeeFlavors);
            CoffeeContext.AddRange(packSizes);
            CoffeeContext.AddRange(productTypes);
            CoffeeContext.AddRange(CoffeeContextSeed.GetPreconfiguredCoffeeMachines(productTypes, modelTypes).ToArray());
            CoffeeContext.AddRange(CoffeeContextSeed.GetPreconfiguredCoffeePods(productTypes, packSizes, coffeeFlavors).ToArray());

            CoffeeContext.SaveChanges();
        }

         
    }
}