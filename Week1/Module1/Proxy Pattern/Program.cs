using System;

namespace Proxy_Pattern
{
    class Program
    {
            static void Main(string[] args)
        {
            Image image1 = new ProxyImage("image1.jpg");
            Image image2 = new ProxyImage("image2.jpg");
            
            Console.WriteLine("Displaying image1:");
            image1.Display();

            Console.WriteLine("Displaying image2:");
            image2.Display();


            
     
        }
    }
}