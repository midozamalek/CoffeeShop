using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CoffeeShop.Infrastructure.Enums
{
    public enum MachineTypeEnum
    {
        [Description("Coffee Machines")]
        Machines = 1,
        [Description("Coffee Pods")]
        Pods
    }
}
