using System;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer.Builder()
                .SetCPU("Intel Core i9")
                .SetRAM("32GB")
                .SetStorage("1TB SSD")
                .SetGPU("NVIDIA RTX 3080")
                .Build();
            
            Console.WriteLine(computer);
            Console.WriteLine("Computer built successfully!");
            Console.WriteLine();

            var officePC= new Computer.Builder()
                .SetCPU("Intel Core i5")
                .SetRAM("16GB")
                .SetStorage("512GB SSD")
                .Build();

            Console.WriteLine("Office PC");
            Console.WriteLine(officePC);


        }
    }
}