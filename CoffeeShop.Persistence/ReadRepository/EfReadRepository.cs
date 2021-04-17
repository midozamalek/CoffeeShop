using CoffeeShop.Persistence.Context;
using CoffeeShop.Persistence.Specification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeeShop.Persistence.ReadRepository
{
    public class EfReadRepository<T> : IReadRepository<T> where T : class
    {
        private readonly DbContext _dbContext;

        public EfReadRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<IEnumerable<T>> SearchAsync<TProperty>(ISpecification<T> specification, params string[] includes)
        {
            var queryable = specification.Prepare(_dbContext.Set<T>().AsQueryable());
            queryable = includes.Aggregate(queryable, (query, path) => query.Include(path));
            var result = await specification.Prepare(queryable).ToListAsync();
            return result;
        }
 
    }
}
