using System;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Logger logger1 = Logger.GetInstance();
            
            logger1.Log("This is the first log message.");
            logger1.Log("This is the second log message.");
            
            Logger logger2 = Logger.GetInstance();
            logger2.Log("Second log message");
            
            Console.WriteLine($"Are both logger instances the same? {logger1 == logger2}");
        }
    }
}