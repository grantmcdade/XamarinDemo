using Demo.Interfaces;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.DataAccess.Memory
{
    public class CustomerDataAccess : IRepository<Customer>
    {
        public CustomerDataAccess()
        {
            Customers = new List<Customer>()
            {
                new Customer() {Id=1, Name="Bob", Tel="123"},
                new Customer() {Id=1, Name="Fred", Tel="123"},
                new Customer() {Id=1, Name="Steve", Tel="123"},
                new Customer() {Id=1, Name="Paul", Tel="123"},
                new Customer() {Id=1, Name="Mark", Tel="123"},
                new Customer() {Id=1, Name="John", Tel="123"},
                new Customer() {Id=1, Name="Noah", Tel="123"},
                new Customer() {Id=1, Name="Liam", Tel="123"}
            };
        }

        public IEnumerable<Customer> Customers { get; set; }

        public Customer Get(int id)
        {
            return Customers.Where(c => c.Id == id).SingleOrDefault();
        }

        public IEnumerable<Customer> GetAll()
        {
            return Customers;
        }
    }
}
