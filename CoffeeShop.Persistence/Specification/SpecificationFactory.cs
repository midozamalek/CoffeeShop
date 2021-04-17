using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Persistence.Specification
{
    public class SpecificationFactory : ISpecificationFactory
    {
        public ISpecification<T> Create<T>()
        {
            return new NullSpecification<T>();
        }
    }
}
