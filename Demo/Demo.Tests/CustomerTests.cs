using Demo.Business;
using System;
using Xunit;
using System.Linq;

namespace Demo.Tests
{
    public class CustomerTests
    {
        [Fact]
        public async void GetAllIsWorking()
        {
            var mockCustomerData = new MockCustomerData();
            var service = new CustomerService(mockCustomerData);

            var c = await service.GetAll();

            Assert.Equal(8, c.Count());
        }

        [Fact]
        public async void GetIsWorking()
        {
            var mockCustomerData = new MockCustomerData();
            var service = new CustomerService(mockCustomerData);

            var c = await service.Get(2);

            Assert.Equal(2, c.Id);
        }
    }
}
