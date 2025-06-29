using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var stock =new StockMarket("TechCorp");

            var mobileUser= new MobileApp("Rahul");

            var webUser = new WebApp("Anjali");

            stock.RegisterObserver(mobileUser);
            stock.RegisterObserver(webUser);


            stock.SetPrice(150.75m);
            stock.SetPrice(155.00m);

            stock.RemoveObserver(mobileUser);

            stock.SetPrice(160.50m);
        }
    }
}