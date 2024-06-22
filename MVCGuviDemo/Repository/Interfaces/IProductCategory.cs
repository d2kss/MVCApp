using MVCGuviDemo.Models;

namespace MVCGuviDemo.Repository.Interfaces
{
    public interface IProductCategory : IRepository<Prdouct>
    {
        void Update(Prdouct obj);
        void Save();
    }
}
