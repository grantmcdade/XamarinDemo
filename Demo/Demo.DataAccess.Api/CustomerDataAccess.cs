using System.Net;
using Demo.Interfaces;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Demo.DataAccess.Api
{
    public class CustomerDataAccess : IRepository<Customer>
    {
        public Task<Customer> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri("http://192.168.1.7:57783");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            IEnumerable<Customer> customers = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync("api/customers");
                if (response.IsSuccessStatusCode)
                {
                    var value = await response.Content.ReadAsStringAsync(); //ReadAsAsync<IEnumerable<Customer>>();
                    customers = JsonConvert.DeserializeObject<List<Customer>>(value);
                }

            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                if (customers == null)
                {
                    customers = new List<Customer>();
                }
            }
            return customers;
        }
    }
}
