using System;

namespace _09___Inheritance
{
    // Child
    internal class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
        }

        // Method to watch TV
        public void WatchTV()
        {
            // First check if the TV is on
            if (IsOn)
            {
                // Watching TV
                Console.WriteLine("Watching TV!");
            }
            else
            {
                // Print error message
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
