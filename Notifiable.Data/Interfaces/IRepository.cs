using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Notifiable.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        IQueryable<TEntity> Queryable(bool @readonly = false);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> collection);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> collection);

        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> collection);
    }
}
