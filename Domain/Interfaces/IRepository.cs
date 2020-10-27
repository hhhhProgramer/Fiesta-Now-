using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Entity;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task Add(T entity);
        Task Delete(int id);
        Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Update(T entity);
    }
}