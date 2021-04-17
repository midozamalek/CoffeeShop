using CoffeeShop.Persistence.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeeShop.Persistence.ReadRepository
{
    public interface IReadRepository<T>
    {
        Task<IEnumerable<T>> SearchAsync<TProperty>(ISpecification<T> specification, params string[] includes);        
    }
}
