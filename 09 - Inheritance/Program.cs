using System;

namespace _09___Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            // Method of base class
            myRadio.SwitchOn();
            // Method of child class
            myRadio.ListenRadio();

            TV myTV = new TV(false, "Samsung");
            // Method of base class
            myTV.SwitchOn();
            // Method of child class
            myTV.WatchTV();

            Console.Read();
        }
    }
}
