using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExampleAPI.Services
{
    public interface IRepo<K,T>
    {
        Task<ICollection<T>> GetAll();
        Task<T> Get(K key);
        Task<T> Add(T item);
        Task<T> Update(T item);
        Task<T> Delete(K key);
    }
}
