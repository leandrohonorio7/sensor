using System.Collections.Generic;
using System.Threading.Tasks;

namespace domain.interfaces.irepository
{
    public interface IRepositoryBase <T> where T : class
    {
        Task<T> AddAsync(T obj);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Dispose();
    }
}