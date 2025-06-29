using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    public class PublicDocumnet: IDocument
    {
        public void Open() { 
         Console.WriteLine("Opening PDF document...");
        }
    }
}
