﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class EmailNotifier:INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent with message: {message}");
        }
    }
    
}
