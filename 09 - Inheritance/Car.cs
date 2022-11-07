using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Inheritance
{
    // Subclass car that extends Vehicle
    internal class Car : Vehicle, IDestroyable
    {
        // Implementing the interface's property
        public string DestructionSound { get; set; }

        // Creating a new property to store the destroyable objects nearby
        // When a car gets destroyed it should also destroy the nearby object
        // This list is of type IDestroyable which means it can store any object
        // That implements this.interface and we can only access the properties
        // And methods in this interface
        public List<IDestroyable> DestroyablesNearby;

        // Simple constructor
        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;

            // Initialize the interface's property with a value in the constructor
            DestructionSound = "CarExplosianSound.mp3";
            // Initialize the list of destroyable objects
            DestroyablesNearby = new List<IDestroyable>();
        }

        // Implementing the interface's method
        public void Destroy()
        {
            // When a car gets destroyed, we should play the dwestruction sound
            // And create fire effect
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");
            // Go through each destroyable object nearby and call it's destroy method
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
