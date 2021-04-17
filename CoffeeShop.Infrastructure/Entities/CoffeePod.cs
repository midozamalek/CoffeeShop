using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoffeeShop.Infrastructure.Entities
{
    public class CoffeePod
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public CoffeeFlavor CoffeeFlavor { get; set; }
        public int CoffeeFlavorId { get; set; }
        public PackSize PackSize { get; set; }
        public int PackSizeId { get; set; }
    }
}
