using CoffeeShop.Business.Services;
using CoffeeShop.Infrastructure.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeeShop.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        
        private readonly ILogger<CoffeeController> _logger;
        private readonly ICoffeeService _coffeeService;


        public CoffeeController(ILogger<CoffeeController> logger, ICoffeeService coffeeService)
        {
            _logger = logger;
            _coffeeService = coffeeService;
        }

        [HttpGet("SearchCoffeeMachines")]
        public  async Task<OperationResultDto<IEnumerable<CoffeeMachineDto>>> SearchCoffeeMachines(int? productTypeId, int? modelTypeId, bool? isWaterLineCompatible)
        {
          return await _coffeeService.SearchCoffeeMachines(productTypeId, modelTypeId, isWaterLineCompatible, CancellationToken.None);            
        }

        [HttpGet("SearchCoffeePods")]
        public async Task<OperationResultDto<IEnumerable<CoffeePodDto>>> SearchCoffeePods(int? productTypeId, int? coffeeFlavorId, int? packSizeId)
        {
            return await _coffeeService.SearchCoffeePods(productTypeId, coffeeFlavorId, packSizeId, CancellationToken.None);
        }

    }
}
