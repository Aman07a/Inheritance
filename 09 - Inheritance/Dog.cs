using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Inheritance
{
    internal class Dog : Animal
    {
        // Bool property to check if the dog IsHappy
        public bool IsHappy { get; set; }

        // Simple constructor where we pass the name and age to our base construct
        public Dog(string name, int age) : base(name, age)
        {
            // All dogs are happy
            IsHappy = true;
        }

        // Simple override of the virtual method Eat
        public override void Eat()
        {
            // To call the eat method from our base class
            // We use the keword "base"
            base.Eat();
        }

        // Override of the virtual method MakeSound
        public override void MakeSound()
        {
            // Since every animal will make a totally different sound
            // Each animal will implement their own version of MakeSound
            Console.WriteLine("Wuuf!");
            // base.MakeSound();
        }

        public override void Play()
        {
            // Check if the dog is happy
            // If: True, call the Play method from the base
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
