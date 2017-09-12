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
                new Customer() {Id=2, Name="Fred", Tel="123"},
                new Customer() {Id=3, Name="Steve", Tel="123"},
                new Customer() {Id=4, Name="Paul", Tel="123"},
                new Customer() {Id=5, Name="Mark", Tel="123"},
                new Customer() {Id=6, Name="John", Tel="123"},
                new Customer() {Id=7, Name="Noah", Tel="123"},
                new Customer() {Id=8, Name="Liam", Tel="123"}
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
