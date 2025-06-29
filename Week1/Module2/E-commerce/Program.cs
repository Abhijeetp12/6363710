
using System;
using System.Linq;

namespace E_commerce

{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product("P01", "Laptop", "Electronics"),
                new Product("P02", "Mobile", "Electronics"),
                new Product("P03", "Shoes", "Footwear"),
                new Product("P04", "Watch", "Accessories")
            };

            string searchTarget = "Shoes";

            int linearIdx = SearchAlgorithms.LinearSearch(products, searchTarget);
            Console.WriteLine(linearIdx != -1
                ? $"Linear Search:'{products[linearIdx].ProductName}'"
                : "Linear Search: Product not found");

            Product[] sortedProducts = products.OrderBy(p => p.ProductName).ToArray();

            int binaryIdx = SearchAlgorithms.BinarySearch(sortedProducts, searchTarget);
            Console.WriteLine(binaryIdx != -1
                ? $"Binary Search:'{sortedProducts[binaryIdx].ProductName}'"
                : "Binary Search: Product not found");
        }
    }
}
