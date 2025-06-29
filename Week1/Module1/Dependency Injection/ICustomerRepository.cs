using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public interface ICustomerRepository
    {
        Customer? FindCustomerById(int id);
    }
}
