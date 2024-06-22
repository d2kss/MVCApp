using MVCGuviDemo.Models;

namespace MVCGuviDemo.Repository.Interfaces
{
    public interface ICategoryRepository:IRepository<Category>
    {
        void Update(Category obj);
        void Save();
    }
}
