using CoffeeShop.Infrastructure.Entities;
using CoffeeShop.Infrastructure.Enums;
using CoffeeShop.Persistence.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Business.Services
{
   public static  class CoffeeMachineSpecificationExtensions
    {
        public static ISpecification<CoffeeMachine> ProductTypes(this ISpecification<CoffeeMachine> specification,int? productTypeId)
        {
            return specification.And(x => x.ProductTypeId == productTypeId || productTypeId == null);
        }
        public static ISpecification<CoffeeMachine> ModelTypes(this ISpecification<CoffeeMachine> specification, int? modelTypeId)
        {
            return specification.And(x => x.ModelTypeId == modelTypeId || modelTypeId == null);
        }
        public static ISpecification<CoffeeMachine> WaterLineCompatible(this ISpecification<CoffeeMachine> specification, bool? WaterLineCompatible)
        {
            return specification.And(x => x.IsWaterLineCompatible == WaterLineCompatible || WaterLineCompatible == null);
        }
     }
}
