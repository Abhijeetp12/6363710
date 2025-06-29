using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class StripeGateway
    {
        public void MakePayment(float amount)
        {
            Console.WriteLine($"Strpe Charged {amount}");
        }
    }
}
