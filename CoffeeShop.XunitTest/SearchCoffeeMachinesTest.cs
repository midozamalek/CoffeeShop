using CoffeeShop.Business.Services;
using CoffeeShop.Infrastructure.Dto;
using CoffeeShop.Infrastructure.Entities;
using CoffeeShop.Persistence.ReadRepository;
using CoffeeShop.Persistence.Specification;
using NFluent;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CoffeeShop.XunitTest
{
    public class SearchCoffeeMachinesTest : IClassFixture<CoffeeMockDbContext>
    {
        private readonly CoffeeMockDbContext _mockDbContext;
        private readonly CoffeeService _coffeeService;

        public SearchCoffeeMachinesTest(CoffeeMockDbContext mockDbContext)
        {
            _mockDbContext = mockDbContext;
            var coffeeMachineRepository = new EfReadRepository<CoffeeMachine>(_mockDbContext.CoffeeContext);
            var coffeePodRepository = new EfReadRepository<CoffeePod>(_mockDbContext.CoffeeContext);

            var specificationFactory = new SpecificationFactory();
            _coffeeService = new CoffeeService(specificationFactory, coffeeMachineRepository, coffeePodRepository,null);
        }

        [Theory]
        [Xunit.InlineDataAttribute(1)]
        public async Task All_large_machines(int? productTypeId)
        {
            // Arrange 
            var count = 3;

            // Act          
            var searchResult = await _coffeeService.SearchCoffeeMachines(productTypeId, null, null, CancellationToken.None);

            // Assert
            Check.That(searchResult.Data.Count()).IsEqualTo(count);
        }

        [Theory]
        [Xunit.InlineDataAttribute(4)]
        public async Task All_large_Pods(int? productTypeId)
        {
            // Arrange 
            var count = 10;

            // Act
            var searchResult = await _coffeeService.SearchCoffeePods(productTypeId, null, null, CancellationToken.None);

            // Assert
            Check.That(searchResult.Data.Count()).IsEqualTo(count);
        }

        [Theory]
        [Xunit.InlineDataAttribute(6,1)]
        public async Task All_esspresso_Vanilla_Pods(int? productTypeId,int? CoffeeFlavorId)
        {
            // Arrange 
            var count = 3;

            // Act
            var searchResult = await _coffeeService.SearchCoffeePods(productTypeId, CoffeeFlavorId, null, CancellationToken.None);

            // Assert
            Check.That(searchResult.Data.Count()).IsEqualTo(count);
        }

        [Theory]
        [Xunit.InlineDataAttribute(3)]
        public async Task All_esspresso_machine(int? productTypeId)
        {
            // Arrange 
            var count = 3;

            // Act
            var searchResult = await _coffeeService.SearchCoffeeMachines(productTypeId, null, null, CancellationToken.None);

            // Assert
            Check.That(searchResult.Data.Count()).IsEqualTo(count);
        }


        [Theory]
        [Xunit.InlineDataAttribute(5)]
        public async Task All_small_Pods(int? productTypeId)
        {
            // Arrange 
            var count = 10;

            // Act
            var searchResult = await _coffeeService.SearchCoffeePods(productTypeId, null, null, CancellationToken.None);

            // Assert
            Check.That(searchResult.Data.Count()).IsEqualTo(count);
        }


        [Theory]
        [Xunit.InlineDataAttribute(4)]
        public async Task All_Pods_in7Dozen(int? packSizeId)
        {
            // Arrange 
            var count = 2;

            // Act
            var searchResult = await _coffeeService.SearchCoffeePods(null, null, packSizeId, CancellationToken.None);

            // Assert
            Check.That(searchResult.Data.Count()).IsEqualTo(count);
        }
    }
}