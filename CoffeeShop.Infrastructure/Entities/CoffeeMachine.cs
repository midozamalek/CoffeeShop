using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoffeeShop.Infrastructure.Entities
{
    public class CoffeeMachine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ModelType ModelType { get; set; }
        public int ModelTypeId { get; set; }
        public bool IsWaterLineCompatible { get; set; }
    }
}
