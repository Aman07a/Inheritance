using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Inheritance
{
    internal class Animal
    {
        // Name of the properties
        public string Name { get; set; }
        // Age of the properties
        public int Age { get; set; }
        // IsHungry boolean to check whether the animal is hungry
        public bool IsHungry { get; set; }

        // Simple constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            // In our case all our animals are hungry by default
            IsHungry = true;
        }

        // An empty virtual method MakeSound for other classes to override
        public virtual void MakeSound()
        {
            // 
        }

        // A virtual method called Eat which sub classes can override
        public virtual void Eat()
        {
            // Check if animal is hungry
            if (IsHungry)
            {
                // If: True, then print the name of the animal + "is eating"
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                // Otherwise: Print that the animal is not hungry
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        // Virtual method Play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
