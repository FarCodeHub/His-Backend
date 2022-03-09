using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Repositories.His
{

    public interface IRepository
    {
        IUnitOfWork UnitOfWork { get; set; }
        Task Save();
    }
    public interface IRepository<T> : IRepository where T : class
    {
        void Add(T entity);
        void AddRange(List<T> entity);
        void RemoveRange(List<T> entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        Task<T> FindById(long Id);

    }
}
