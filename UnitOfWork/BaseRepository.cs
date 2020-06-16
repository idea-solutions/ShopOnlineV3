using Domain.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace UnitOfWork
{
    public sealed class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly WebOnlineDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(WebOnlineDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet ;
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }


        public T GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void CreateNew(T t)
        {
            _dbSet.Add(t);
        }

        public T CreateNewAddReturnObject(T t)
        {
            _dbSet.Add(t);
            return t;
        }

        public void Edit(T t)
        {
            _dbSet.Attach(t);
            _dbContext.Entry(t).State = EntityState.Modified;
        }

        public void Delete(Guid id)
        {
            var data = _dbSet.Find(id);
            _dbSet.Remove(data);
        }
    }
}