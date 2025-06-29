using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class StripeAdapter: PaymentProcessor
    {
        private readonly StripeGateway _stripe;
        public StripeAdapter(StripeGateway stripe)
        {
            _stripe = stripe;
        }
        public void ProcessPayment(decimal amount)
        {
            
            _stripe.MakePayment((float)amount);
        }
    }
    
}
