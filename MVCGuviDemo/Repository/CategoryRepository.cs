using MVCGuviDemo.Data;
using MVCGuviDemo.Models;
using MVCGuviDemo.Repository.Interfaces;
using System.Linq.Expressions;

namespace MVCGuviDemo.Repository
{
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        private readonly MVCGuviDemoContext _context;
        public CategoryRepository(MVCGuviDemoContext context):base(context) 
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Category obj)
        {
          _context.Category.Update(obj);
        }
    }
}
