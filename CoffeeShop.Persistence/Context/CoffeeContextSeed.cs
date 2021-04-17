using CoffeeShop.Infrastructure.Entities;
using CoffeeShop.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Persistence.Context
{
    public class CoffeeContextSeed
    {       

        public static IEnumerable<ProductType> GetPreconfiguredProductTypes()
        {
            return new List<ProductType>
            {
                new ProductType()
                {
                    Id = 1,
                    Name = "large machine",
                    MachineTypeEnum = MachineTypeEnum.Machines
                },
                new ProductType()
                {
                    Id = 2,
                    Name = "small machine",
                    MachineTypeEnum = MachineTypeEnum.Machines
                },
                 new ProductType()
                {
                    Id = 3,
                    Name = "espresso machine",
                    MachineTypeEnum = MachineTypeEnum.Machines
                },
                new ProductType()
                {
                    Id = 4,
                    Name = "large coffee pod",
                    MachineTypeEnum = MachineTypeEnum.Pods
                },
                 new ProductType()
                {
                    Id = 5,
                    Name = "small coffee pod",
                    MachineTypeEnum = MachineTypeEnum.Pods
                },
                  new ProductType()
                {
                    Id = 6,
                    Name = "espresso pod",
                    MachineTypeEnum = MachineTypeEnum.Pods
                }
            };
        }
        public static IEnumerable<ModelType> GetPreconfiguredModelTypes()
        {
            return new List<ModelType>
            {
                new ModelType()
                {
                    Id = 1,
                    Name = "base model",
                },
                new ModelType()
                {
                    Id = 2,
                    Name = "premium model",
                },
                 new ModelType()
                {
                    Id = 3,
                    Name = "deluxe model",
                },
            };
        }
        public static IEnumerable<PackSize> GetPreconfiguredPackSizes()
        {
            return new List<PackSize>
            {
                new PackSize()
                {
                    Id = 1,
                    Name = "1 dozen (12)",
                },
                new PackSize()
                {
                    Id = 2,
                    Name = "3 dozen (36)",
                },
                 new PackSize()
                {
                    Id = 3,
                    Name = "5 dozen (60)",
                },
                 new PackSize()
                {
                    Id = 4,
                    Name = "7 dozen (84)",
                },
            };
        }

        public static IEnumerable<CoffeeFlavor> GetPreconfiguredCoffeeFlavors()
        {
            return new List<CoffeeFlavor>
            {
                new CoffeeFlavor()
                {
                    Id = 1,
                    Name = "vanilla",
                },
                new CoffeeFlavor()
                {
                    Id = 2,
                    Name = "caramel",
                },
                 new CoffeeFlavor()
                {
                    Id = 3,
                    Name = "psl",
                },
                 new CoffeeFlavor()
                {
                    Id = 5,
                    Name = "mocha",
                },
                 new CoffeeFlavor()
                {
                    Id = 6,
                    Name = "hazelnut",
                },
            };
        }

        public static IEnumerable<CoffeeMachine> GetPreconfiguredCoffeeMachines(IEnumerable<ProductType> productTypes, IEnumerable<ModelType> modelTypes)
        {
            return new List<CoffeeMachine>
            {
                new CoffeeMachine()
                {
                    Id = 1,
                    Name = "CM001",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small machine").Id,
                    ModelTypeId = modelTypes.FirstOrDefault(x=>x.Name == "base model").Id,
                },
                 new CoffeeMachine()
                {
                    Id = 2,
                    Name = "CM002",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small machine").Id,
                    ModelTypeId = modelTypes.FirstOrDefault(x=>x.Name == "premium model").Id,
                }, new CoffeeMachine()
                {
                    Id = 3,
                    Name = "CM003",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small machine").Id,
                    ModelTypeId = modelTypes.FirstOrDefault(x=>x.Name == "deluxe model").Id,
                    IsWaterLineCompatible = true
                }, new CoffeeMachine()
                {
                    Id = 4,
                    Name = "CM101",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large machine").Id,
                    ModelTypeId = modelTypes.FirstOrDefault(x=>x.Name == "base model").Id,
                }, new CoffeeMachine()
                {
                    Id = 5,
                    Name = "CM102",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large machine").Id,
                    ModelTypeId = modelTypes.FirstOrDefault(x=>x.Name == "premium model").Id,
                    IsWaterLineCompatible = true
                }, new CoffeeMachine()
                {
                    Id = 6,
                    Name = "CM103",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large machine").Id,
                    ModelTypeId = modelTypes.FirstOrDefault(x=>x.Name == "deluxe model").Id,
                     IsWaterLineCompatible = true
                }, new CoffeeMachine()
                {
                    Id = 7,
                    Name = "EM001",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "espresso machine").Id,
                    ModelTypeId = modelTypes.FirstOrDefault(x=>x.Name == "base model").Id,
                }, new CoffeeMachine()
                {
                    Id = 8,
                    Name = "EM002",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "espresso machine").Id,
                    ModelTypeId = modelTypes.FirstOrDefault(x=>x.Name == "premium model").Id,
                }, new CoffeeMachine()
                {
                    Id = 9,
                    Name = "EM003",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "espresso machine").Id,
                    ModelTypeId = modelTypes.FirstOrDefault(x=>x.Name == "deluxe model").Id,
                    IsWaterLineCompatible = true
                }
            };
        }

         
        public static IEnumerable<CoffeePod> GetPreconfiguredCoffeePods(IEnumerable<ProductType> productTypes, IEnumerable<PackSize> packSizes, IEnumerable<CoffeeFlavor> coffeeFlavors)
        {
            return new List<CoffeePod>
            {
                new CoffeePod()
                {
                    Id = 1,
                    Name = "CP001",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "1 dozen (12)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "vanilla").Id,
                },
                 new CoffeePod()
                {
                     Id = 2,
                    Name = "CP003",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "3 dozen (36)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "vanilla").Id,
                }, new CoffeePod()
                {
                    Id = 3,
                    Name = "CP011",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "1 dozen (12)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "caramel").Id,
                }, new CoffeePod()
                {
                    Id = 4,
                    Name = "CP013",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "3 dozen (36)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "caramel").Id,
                }, new CoffeePod()
                {
                    Id = 5,
                    Name = "CP021",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "1 dozen (12)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "psl").Id,
                }, new CoffeePod()
                {
                    Id=6,
                    Name = "CP023",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "3 dozen (36)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "psl").Id,
                }, new CoffeePod()
                {
                    Id=7,
                    Name = "CP031",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "1 dozen (12)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "mocha").Id,
                }, new CoffeePod()
                {
                    Id = 8,
                    Name = "CP033",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "3 dozen (36)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "mocha").Id,
                }, new CoffeePod()
                {
                    Id=9,
                    Name = "CP041",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "1 dozen (12)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "hazelnut").Id,
                }, new CoffeePod()
                {
                    Id = 10,
                    Name = " CP043",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "small coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "3 dozen (36)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "vanilla").Id,
                }, new CoffeePod()
                {
                    Id=11,
                    Name = "CP101",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "1 dozen (12)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "vanilla").Id,
                }, new CoffeePod()
                {
                    Id=12,
                    Name = "CP103",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "3 dozen (36)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "vanilla").Id,
                }, new CoffeePod()
                {
                    Id= 13,
                    Name = "CP111",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "1 dozen (12)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "caramel").Id,
                }, new CoffeePod()
                {
                   Id= 14,
                    Name = "CP113",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "3 dozen (36)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "caramel").Id,
                }, new CoffeePod()
                {
                   Id= 15,
                    Name = "CP121",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "1 dozen (12)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "psl").Id,
                }, new CoffeePod()
                {
                     Id= 16,
                    Name = "CP123",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "3 dozen (36)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "psl").Id,
                }, new CoffeePod()
                {
                     Id= 17,
                    Name = "CP131",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "1 dozen (12)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "mocha").Id,
                }, new CoffeePod()
                {
                    Id= 18,
                    Name = "CP133",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "3 dozen (36)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "mocha").Id,
                }, new CoffeePod()
                {
                    Id= 19,
                    Name = "CP141",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "1 dozen (12)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "hazelnut").Id,
                }, new CoffeePod()
                {
                     Id= 20,
                    Name = "CP143",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "large coffee pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "3 dozen (36)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "hazelnut").Id,
                }, new CoffeePod()
                {
                     Id= 21,
                    Name = "EP003",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "espresso pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "3 dozen (36)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "vanilla").Id,
                }, new CoffeePod()
                {
                      Id= 22,
                    Name = "EP005",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "espresso pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "5 dozen (60)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "vanilla").Id,
                }, new CoffeePod()
                {
                     Id= 23,
                    Name = "EP007",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "espresso pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "7 dozen (84)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "vanilla").Id,
                }, new CoffeePod()
                {
                   Id= 24,
                    Name = "EP013",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "espresso pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "3 dozen (36)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "caramel").Id,
                }, new CoffeePod()
                {
                     Id= 25,
                    Name = "EP015",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "espresso pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "5 dozen (60)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "caramel").Id,
                }, new CoffeePod()
                {
                    Id= 26,
                    Name = "EP017",
                    ProductTypeId = productTypes.FirstOrDefault(x=>x.Name == "espresso pod").Id,
                    PackSizeId = packSizes.FirstOrDefault(x=>x.Name == "7 dozen (84)").Id,
                    CoffeeFlavorId = coffeeFlavors.FirstOrDefault(x=>x.Name == "caramel").Id,
                }
            };
        }


    }
}
