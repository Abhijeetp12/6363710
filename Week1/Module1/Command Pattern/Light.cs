using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is now ON.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Light is now OFF.");
        }
    }
}
