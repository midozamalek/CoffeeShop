using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Infrastructure.Dto
{
   public class CoffeeMachineDto
    {

        public string Name { get; set; }
        public string ProductType { get; set; }
        public string ModelType { get; set; }
        public bool IsWaterLineCompatible { get; set; }
    }
}
