using CoffeeShop.Infrastructure.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShop.Infrastructure.Entities
{
    public class ProductType
    {
      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
      
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public MachineTypeEnum MachineTypeEnum { get; set; }
    }
}
