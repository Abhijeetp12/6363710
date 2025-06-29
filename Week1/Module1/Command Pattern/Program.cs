using System;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Light livingRoomLight= new Light();

            ICommand lightOn = new LightOnCommand(livingRoomLight);
            ICommand lightOff = new LightOffCommand(livingRoomLight);

            RemoteControl remote = new RemoteControl();

            Console.WriteLine("Turning light ON:");
            remote.SetCommand(lightOn);
            remote.PressButton();

            Console.WriteLine("\nTurning light OFF:");
            remote.SetCommand(lightOff);
            remote.PressButton();
        }
    }
}