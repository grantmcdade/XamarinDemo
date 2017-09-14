using Demo.Interfaces;
using Demo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Business
{
    public class CustomerService
    {
        IRepository<Customer> _dataSource;

        public CustomerService(IRepository<Customer> dataSource)
        {
            _dataSource = dataSource;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _dataSource.GetAll();
        }

        public async Task<Customer> Get(int id)
        {
            return await _dataSource.Get(id);
        }
    }
}
