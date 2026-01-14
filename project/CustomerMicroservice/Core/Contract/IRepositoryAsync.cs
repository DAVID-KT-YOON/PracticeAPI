using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contract
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<int> Insert(T entity);
        Task<IEnumerable<T>> GetAll();
    }
}
