using Microsoft.EntityFrameworkCore;
using MVCGuviDemo.Data;
using MVCGuviDemo.Repository.Interfaces;
using System.Linq.Expressions;

namespace MVCGuviDemo.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MVCGuviDemoContext _context;
        internal DbSet<T> DbSet { get;  set; }
        public Repository(MVCGuviDemoContext context)
        {
            _context = context;
            this.DbSet=_context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = DbSet;
            return query.ToList();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = DbSet;
            query=query.Where(filter);
            return query.FirstOrDefault();
        }

        public void Add(T entity)
        {
           DbSet.Add(entity);
        }

        

       
        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(T obj)
        {
            DbSet.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
