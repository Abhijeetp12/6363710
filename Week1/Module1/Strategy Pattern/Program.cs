using Strategy_Pattern;
using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new PaymentContext();

            payment.SetPaymentStrategy(new CreditCardPayment("1234-5678-9012-3456"));
            payment.ExecutePayment(123.45m);

            payment.SetPaymentStrategy(new PayPalPayment("user@example.com"));
            payment.ExecutePayment(67.89m);

        }
    }
}