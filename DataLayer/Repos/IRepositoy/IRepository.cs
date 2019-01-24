using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer.Repos.IRepositoy
{
    public interface IRepository<T, Key> 
        where T : class
        where Key: struct
    {
        IEnumerable<T> Get(Key Id);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(Key Id);
        void Delete(T entity);
        void Update(T entity);
    }
}
