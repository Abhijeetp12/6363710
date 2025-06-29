using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dependency_Injection
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;

        }
        public void DisplayCustomer(int id)
        {
            var customer = _repository.FindCustomerById(id);
            if (customer != null)
            {
                Console.WriteLine($"Customer Found: ID={customer.Id}, Name = {customer.Name}");
                
            }
           else
            {
                Console.WriteLine($"Customer not found with ID {id}");
            }
        }
    }
}
