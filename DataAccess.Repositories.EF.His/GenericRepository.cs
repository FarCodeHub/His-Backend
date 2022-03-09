using DataAccess.Repositories.His;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Repositories.EF.His
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class, new()
    {
        protected EFUnitOfWork _unitOfWork;

        protected GenericRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (EFUnitOfWork)unitOfWork;
        }


        public EFUnitOfWork UnitOfWork
        {

            get { return _unitOfWork; }
            set { _unitOfWork = value; }
        }

        IUnitOfWork IRepository.UnitOfWork
        {
            get
            {
                return _unitOfWork;
            }
            set
            {
                _unitOfWork = (EFUnitOfWork)value;
            }
        }

        public virtual void Add(T entity)
        {
            _unitOfWork.DatabaseContext.Set<T>().Add(entity);
        }



        public virtual void Update(T entity)
        {
            _unitOfWork.DatabaseContext.Set<T>().Attach(entity);
            _unitOfWork.DatabaseContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            _unitOfWork.DatabaseContext.Set<T>().Attach(entity);
            _unitOfWork.DatabaseContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _unitOfWork.DatabaseContext.Set<T>();
        }

        public async Task<T> FindById(long Id)
        {
            return await _unitOfWork.DatabaseContext.Set<T>().FindAsync(new object[] { Id });
        }

       
        public async virtual Task Save()
        {
            await _unitOfWork.Save();
        }

        public virtual void AddRange(List<T> entity)
        {
            _unitOfWork.DatabaseContext.Set<T>().AddRange(entity);
        }
        public virtual void RemoveRange(List<T> entity)
        {
            _unitOfWork.DatabaseContext.Set<T>().RemoveRange(entity);
        }
    }
}
