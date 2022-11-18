using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Interfaces.Service
{
    public interface IService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T tEntity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> Entities);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task Remove(T tEntity);
        Task RemoveRange(IEnumerable<T> Entities);
        Task Update(T tEntity);
    }
}
