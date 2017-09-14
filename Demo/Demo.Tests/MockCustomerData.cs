using Demo.Interfaces;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Demo.Tests
{
    class MockCustomerData : IRepository<Customer>
    {
        public IEnumerable<Customer> Customers { get; set; }

        public MockCustomerData()
        {
            Customers = new List<Customer>()
            {
                new Customer() {Id=1, Name="Bob", Tel="123"},
                new Customer() {Id=2, Name="Fred", Tel="123"},
                new Customer() {Id=3, Name="Steve", Tel="123"},
                new Customer() {Id=4, Name="Paul", Tel="123"},
                new Customer() {Id=5, Name="Mark", Tel="123"},
                new Customer() {Id=6, Name="John", Tel="123"},
                new Customer() {Id=7, Name="Noah", Tel="123"},
                new Customer() {Id=8, Name="Liam", Tel="123"}
            };
        }

        public Task<Customer> Get(int id)
        {
            return Task.FromResult(Customers.Where(c => c.Id == id).SingleOrDefault());
        }

        public Task<IEnumerable<Customer>> GetAll()
        {
            return Task.FromResult(Customers);
        }
    }
}
