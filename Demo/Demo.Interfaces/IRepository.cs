using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);
    }
}
