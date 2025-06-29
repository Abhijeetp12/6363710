using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class RealImage:Image
    {
        private string _fileName;
        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadImageFromDisk();
        }
        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading {_fileName} from disk.");
        }
        public void Display()
        {
            Console.WriteLine($"Displaying {_fileName}.");
        }
    }
}
