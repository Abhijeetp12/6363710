using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class RemoteControl
    {
        private ICommand? _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void PressButton()
        {
            if (_command != null)
            {
                _command.Execute();
            }
            else { 
            Console.WriteLine("No command set.");
            }
        }
    }
}
