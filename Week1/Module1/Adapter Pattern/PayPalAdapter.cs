using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class PayPalAdapter: PaymentProcessor
    {
       private readonly PayPalGateway _payPal;

        public PayPalAdapter(PayPalGateway payPal)
        {
            _payPal = payPal;
        }
        public void ProcessPayment(decimal amount)
        {
            _payPal.SendPayment(amount);
        }
    }

}
