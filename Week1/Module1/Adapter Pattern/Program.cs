using System;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PaymentProcessor paypalProcessor = new PayPalAdapter(new PayPalGateway());
            paypalProcessor.ProcessPayment(100.00m);

            PaymentProcessor stripeProcessor = new StripeAdapter(new StripeGateway());
            stripeProcessor.ProcessPayment(200.00m);
        }
    }
}