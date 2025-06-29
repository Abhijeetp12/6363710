using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class PayPalGateway
    {
        public void SendPayment(decimal amount)
        {
            Console.WriteLine($"Processed payment of {amount} through PayPal.");
        }
    }
}
