using System;

namespace _09___Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Radio myRadio = new Radio(false, "Sony");
            // // Method of base class
            // myRadio.SwitchOn();
            // // Method of child class
            // myRadio.ListenRadio();

            // TV myTV = new TV(false, "Samsung");
            // // Method of base class
            // myTV.SwitchOn();
            // // Method of child class
            // myTV.WatchTV();

            Dog dog = new Dog("Sif", 15);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();

            Console.Read();
        }
    }
}
