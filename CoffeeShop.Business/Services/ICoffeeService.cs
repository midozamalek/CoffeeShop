using CoffeeShop.Infrastructure.Dto;
using CoffeeShop.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeeShop.Business.Services
{
    public interface ICoffeeService
    {
        Task<OperationResultDto<IEnumerable<CoffeeMachineDto>>> SearchCoffeeMachines(int? productTypeId, int? modelTypeId, bool? isWaterLineCompatible, CancellationToken cancellationToken);
        Task<OperationResultDto<IEnumerable<CoffeePodDto>>> SearchCoffeePods(int? productTypeId, int? coffeeFlavorId, int? packSizeId, CancellationToken cancellationToken);
    }
}
