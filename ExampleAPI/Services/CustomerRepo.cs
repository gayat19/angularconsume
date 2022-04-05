using ExampleAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAPI.Services
{
    public class CustomerRepo : IRepo<int, Customer>
    {
        static List<Customer> _customer = new List<Customer>()
        {
            new Customer() { Id = 1, Name ="Tim",Age=22,Phone="9876543210",Pic="/assets/images/1.jpg"},
            new Customer() { Id = 2, Name ="Jim",Age=32,Phone="1122334455",Pic="/assets/images/2.jpg"}
        };
        public async Task<Customer> Add(Customer item)
        {
            var customer = await Get(item.Id);
            if(customer == null)
            {
                _customer.Add(item);
                return item;
            }
            return null;
        }

        public async Task<Customer> Delete(int key)
        {
            var customer = await Get(key);
            if (customer != null)
            {
                _customer.Remove(customer);
                return customer;
            }
            return null;
        }

        public async Task<Customer> Get(int key)
        {
            var customer = _customer.FirstOrDefault(cust => cust.Id == key);
            return customer;
        }

        public async Task<ICollection<Customer>> GetAll()
        {
            if (_customer.Count == 0)
                return null;
            return _customer;
        }

        public async Task<Customer> Update(Customer item)
        {
            var customer = await Get(item.Id);
            if (customer != null)
            {
                customer.Name = item.Name;
                customer.Age = item.Age;
                customer.Phone = item.Phone;    
                customer.Pic = item.Pic;
                return customer;
            }
            return null;
        }
    }
}
