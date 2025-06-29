using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class SlackNotifierDecorator:NotifierDecorator
    {
        public SlackNotifierDecorator(INotifier notifier) : base(notifier)
        {
        }
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Slack notification sent with message: {message}");
        }
    }
}
