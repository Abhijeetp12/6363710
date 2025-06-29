using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class SMSNotifierDecorator:NotifierDecorator
    {
        public SMSNotifierDecorator(INotifier notifier) : base(notifier)
        {
        }
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"SMS sent with message: {message}");
        }
    }
}
