using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class PaymentContext
    {
        private IPaymentStrategy? paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            paymentStrategy = strategy;
        }

        public void ExecutePayment(decimal amount)
        {
            if(paymentStrategy == null)
            {
                Console.WriteLine("No payment method selected");
                return;
            }
            paymentStrategy.Pay(amount);
        }
    }
}
