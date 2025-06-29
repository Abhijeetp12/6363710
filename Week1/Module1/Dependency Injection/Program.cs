using System;

namespace Dependency_Injection { 

    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository repository = new CustomerRepositoryImp();

            CustomerService service = new CustomerService(repository);

            service.DisplayCustomer(2);
            service.DisplayCustomer(5);


        }
    }
}