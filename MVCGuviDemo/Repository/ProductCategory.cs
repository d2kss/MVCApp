using MVCGuviDemo.Data;
using MVCGuviDemo.Models;
using MVCGuviDemo.Repository.Interfaces;
using System.Linq.Expressions;

namespace MVCGuviDemo.Repository
{
    public class ProductCategory : Repository<Prdouct>, IProductCategory
    {
        private readonly MVCGuviDemoContext _context;
        public ProductCategory(MVCGuviDemoContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Prdouct obj)
        {
           _context.Prdoucts.Update(obj);
        }
    }
}
