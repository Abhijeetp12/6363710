using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class CustomerRepositoryImp:ICustomerRepository
    {
        private readonly List<Customer> _customerList=new List<Customer>
        {
            new Customer {Id=1,Name="Raina"},
            new Customer {Id=2,Name="Aditya"},
            new Customer {Id=3,Name="Rohit"}

            };

        public Customer? FindCustomerById(int id)
        {
            return _customerList.FirstOrDefault(c => c.Id == id);
        }


    }
}
