using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Customer_Orders
{
    public class Program
    {
        static void Main(string[] args)
        {
            Order[] orders = new Order[]
            {
                new Order ( 101, "Ayush", 2000.50 ),
                new Order ( 102,  "Brijesh", 1500.00 ),
                new Order ( 103,  "Daksh", 4500.75 ),
                new Order ( 104,  "Faisal", 2500.25 )
            };

            Console.WriteLine("Original Orders:");
            foreach (var order in orders)
                Console.WriteLine(order);

            OrderSort.BubbleSort(orders);
            Console.WriteLine("\nAfter Bubble Sort:");
            foreach (var order in orders)
                Console.WriteLine(order);

            
            orders = new Order[]
            {
                new Order ( 101, "Ayush", 2000.50 ),
                new Order ( 102,  "Brijesh", 1500.00 ),
                new Order ( 103,  "Daksh", 4500.75 ),
                new Order ( 104,  "Faisal", 2500.25 )
            };


            OrderSort.QuickSort(orders, 0, orders.Length - 1);
            Console.WriteLine("\nAfter Quick Sort:");
            foreach (var order in orders)
                Console.WriteLine(order);
        }
    }
}
