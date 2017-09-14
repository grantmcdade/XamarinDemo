using Autofac;
using Demo.Business;
using Demo.DataAccess.Api;
using Demo.Interfaces;
using Demo.Models;
using System;

namespace Demo.Core
{
    public static class DemoContainer
    {
        static IContainer _container;

        public static void PerformRegistration()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CustomerDataAccess>().As<IRepository<Customer>>();
            builder.RegisterType<CustomerService>();

            _container = builder.Build();
        }

        public static T Resolve<T>()
        {
            if (_container == null)
            {
                throw new InvalidOperationException("The container has not been initialised yet.");
            }

            return _container.Resolve<T>();
        }
    }
}
