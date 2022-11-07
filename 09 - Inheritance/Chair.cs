using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Inheritance
{
    // Subclass chair that extends Furniture
    internal class Chair : Furniture, IDestroyable
    {
        // Implementing the interface's property
        public string DestructionSound { get; set; }

        // Simple constructor
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;

            // Initialize the interface's property with a value in the constructor
            DestructionSound = "CarExplosianSound.mp3";
        }

        // Implementing the interface's method
        public void Destroy()
        {
            // When a chair gets destroyed, we should play the dwestruction sound
            // And spawn the destroyed chair parts
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
