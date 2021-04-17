using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Persistence.Specification
{
    public interface ISpecificationFactory
    {
        ISpecification<T> Create<T>();
    }
}
