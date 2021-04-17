using CoffeeShop.Infrastructure.Entities;
using CoffeeShop.Infrastructure.Enums;
using CoffeeShop.Persistence.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Business.Services
{
    public static class CoffeePodSpecificationExtensions
    {
        public static ISpecification<CoffeePod> ProductTypes(this ISpecification<CoffeePod> specification, int? productTypeId)
        {
            return specification.And(x => x.ProductTypeId == productTypeId || productTypeId == null);
        }
        public static ISpecification<CoffeePod> PackSizes(this ISpecification<CoffeePod> specification, int? packSizeId)
        {
            return specification.And(x => x.PackSizeId == packSizeId || packSizeId == null);
        }
        public static ISpecification<CoffeePod> CoffeeFlavors(this ISpecification<CoffeePod> specification, int? coffeeFlavorId)
        {
            return specification.And(x => x.CoffeeFlavorId == coffeeFlavorId || coffeeFlavorId == null);
        }
    }
}
