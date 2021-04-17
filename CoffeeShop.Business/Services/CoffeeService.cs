using CoffeeShop.Infrastructure.Dto;
using CoffeeShop.Infrastructure.Entities;
using CoffeeShop.Persistence.ReadRepository;
using CoffeeShop.Persistence.Specification;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeeShop.Business.Services
{
    public class CoffeeService : ICoffeeService
    {
        private readonly IReadRepository<CoffeeMachine> _coffeeMachineRepository;
        private readonly ISpecificationFactory _specificationFactory;
        private readonly IReadRepository<CoffeePod> _coffeePodRepository;   
        private readonly ILogger<CoffeeService> _logger;

        public CoffeeService(ISpecificationFactory specificationFactory,
            IReadRepository<CoffeeMachine> coffeeMachineRepository,
            IReadRepository<CoffeePod> coffeePodRepository,
            ILogger<CoffeeService> logger)
        {
            _coffeeMachineRepository = coffeeMachineRepository;
            _coffeePodRepository = coffeePodRepository;
            _specificationFactory = specificationFactory;
            _logger = logger;
        }

        public async Task<OperationResultDto<IEnumerable<CoffeeMachineDto>>> SearchCoffeeMachines(int? productTypeId,int? modelTypeId,bool? isWaterLineCompatible, CancellationToken cancellationToken)
        {
            try
            {
                var specification = _specificationFactory.Create<CoffeeMachine>()
                                                              .ProductTypes(productTypeId)
                                                              .ModelTypes(modelTypeId)
                                                              .WaterLineCompatible(isWaterLineCompatible);

                var result = await _coffeeMachineRepository
                    .SearchAsync<CoffeeMachine>(specification, "ProductType", "ModelType");

                var data = result.Select(c => new CoffeeMachineDto()
                {
                    Name = c.Name,
                    IsWaterLineCompatible = c.IsWaterLineCompatible,
                    ModelType = c.ModelType.Name,
                    ProductType = c.ProductType.Name
                });
                return new OperationResultDto<IEnumerable<CoffeeMachineDto>>()
                {
                    Data = data,
                    Status = OperationResultStatusEnum.Succeeded
                };

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "SearchCoffeeMachinesException");
                return new OperationResultDto<IEnumerable<CoffeeMachineDto>>()
                {
                    Messages = new List<string>() { "An error occurred please contact administrator." },
                    Status = OperationResultStatusEnum.Failed
                };
            }
        }

        public async Task<OperationResultDto<IEnumerable<CoffeePodDto>>> SearchCoffeePods(int? productTypeId, int? coffeeFlavorId, int? packSizeId, CancellationToken cancellationToken)
        {
            try
            {
                var specification = _specificationFactory.Create<CoffeePod>()
                                                               .ProductTypes(productTypeId)
                                                               .PackSizes(packSizeId)
                                                               .CoffeeFlavors(coffeeFlavorId);

                var result = await _coffeePodRepository
                    .SearchAsync<CoffeePod>(specification, "ProductType", "CoffeeFlavor", "PackSize");

                var data = result.Select(c => new CoffeePodDto()
                {
                    Name = c.Name,
                    PackSize = c.PackSize.Name,
                    CoffeeFlavor = c.CoffeeFlavor.Name,
                    ProductType = c.ProductType.Name
                });
                return new OperationResultDto<IEnumerable<CoffeePodDto>>()
                {
                    Data = data,
                    Status = OperationResultStatusEnum.Succeeded
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "SearchCoffeePodsException");
                return new OperationResultDto<IEnumerable<CoffeePodDto>>()
                {
                    Messages = new List<string>() { "An error occurred please contact administrator." },
                    Status = OperationResultStatusEnum.Failed
                };
            }
        }
    }
}
