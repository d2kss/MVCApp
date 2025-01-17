﻿using MVCGuviDemo.Models;
using System.Linq.Expressions;

namespace MVCGuviDemo.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);

        void Remove(T entity);

        void Update(T obj);
        void Save();
    }
}
