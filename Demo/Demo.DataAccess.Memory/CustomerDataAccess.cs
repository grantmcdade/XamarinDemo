using Demo.Interfaces;
using Demo.Models;
using System;
using System.Collections.Generic;

namespace Demo.DataAccess.Memory
{
    public class CustomerDataAccess : IRepository<Customer>
    {
        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
