using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager manager = new InventoryManager();

          
            Product p1 = new Product("P01", "Laptop", 10, 70000.0);
            Product p2 = new Product("P02", "Mobile", 20, 25000.0);
            Product p3 = new Product("P03", "TV", 30, 40000.0);

            manager.AddProduct(p1);
            manager.AddProduct(p2);
            manager.AddProduct(p3);

            
            Console.WriteLine(" Inventory after adding products ");
            manager.DisplayInventory();

           
            manager.UpdateProduct("P01", 12, 64000.0);
            Console.WriteLine(" Inventory after updating Laptop ");
            manager.DisplayInventory();

            
            manager.DeleteProduct("P02");
            Console.WriteLine(" Inventory after deleting Mobile ");
            manager.DisplayInventory();
        }
    }
}
