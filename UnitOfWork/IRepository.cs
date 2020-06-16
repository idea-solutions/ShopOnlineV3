using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace UnitOfWork
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        public IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");

        T GetById(Guid id);

        void CreateNew(T t);

        T CreateNewAddReturnObject(T t);

        void Edit(T t);

        void Delete(Guid id);
    }
}