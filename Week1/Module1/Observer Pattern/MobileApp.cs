using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class MobileApp : IObserver
    {
        private string _user;

        public MobileApp(string user)
        {
            _user = user;
        }
        public void Update(string stockName, decimal newPrice)
        {
            Console.WriteLine($"Mobile App Notification for {_user}: Stock {stockName} has a new price: {newPrice}");
        }
    }
}
