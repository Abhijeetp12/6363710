using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class StockMarket:IStock
    {
        private List<IObserver> observers = new List<IObserver>();
        private string _stockName;
        private decimal _price;

        public StockMarket(string stockName)
        {
            _stockName = stockName;
           
        }
        public void SetPrice(decimal newPrice)
        {
            _price = newPrice;
            Console.WriteLine($"\n stock price updated:{_stockName}={_price}");
            NotifyObservers();
        }
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(_stockName, _price);
            }
        }
    }
}
