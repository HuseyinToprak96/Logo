using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Interfaces.Repository
{
    public interface IGenericRepository<T> where T:class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<T,bool>> expression);
        Task AddAsync(T tEntity);
        Task AddRangeAsync(IEnumerable<T> Entities);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        void Remove(T tEntity);
        void RemoveRange(IEnumerable<T> Entities);
        void Update(T tEntity);
    }
}
