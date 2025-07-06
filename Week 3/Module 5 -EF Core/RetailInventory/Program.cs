using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RetailInventory
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("All Products");
            var products = await context.Products.ToListAsync();
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name}={p.Price}");
            }

            Console.WriteLine("Find by ID");
            var product = await context.Products.FindAsync(1);
            Console.WriteLine($"Found: {product?.Name ?? "Not found"}");

            Console.WriteLine("First Product with Price > 50,000");
            var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
            Console.WriteLine($"Expensive: {expensive?.Name ?? "None"}");
        }
    }
}
