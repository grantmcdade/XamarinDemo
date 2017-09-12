using Demo.Interfaces;
using Demo.Models;
using System.Collections.Generic;

namespace Demo.Business
{
    public class CustomerService
    {
        IRepository<Customer> _dataSource;

        public CustomerService(IRepository<Customer> dataSource)
        {
            _dataSource = dataSource;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _dataSource.GetAll();
        }

        public Customer Get(int id)
        {
            return _dataSource.Get(id);
        }
    }
}
