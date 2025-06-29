using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class WebApp:IObserver
    {
        private string _client;

        public WebApp(string client)
        {
            _client = client;
        }
        public void Update(string stockName, decimal newPrice)
        {
            Console.WriteLine($"Web App Notification for {_client}: Stock {stockName} has a new price: {newPrice}");
        }
    }
}
