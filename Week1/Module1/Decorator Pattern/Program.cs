using System;

namespace Decorator_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            INotifier emailNotifier = new EmailNotifier();

            INotifier smsNotifier = new SMSNotifierDecorator(emailNotifier);
            INotifier slackNotifier = new SlackNotifierDecorator(smsNotifier);

            slackNotifier.Send("Hello, this is a test message!");
        }
    }
}