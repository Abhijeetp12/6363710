using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class PayPalPayment:IPaymentStrategy
    {
        private string _email;

        public PayPalPayment(string email)
        {
            _email = email;
        }
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal: {_email}");
        }
    }
}
