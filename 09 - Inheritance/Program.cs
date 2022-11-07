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

            // Dog dog = new Dog("Sif", 15);
            // Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            // dog.MakeSound();
            // dog.Play();
            // dog.Eat();

            Post post1 = new Post("Thanks for the birthday wishes", true, "User");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my GitHub", "User", "https://github.com/Aman07a", true);
            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();

            Console.Read();
        }
    }
}
