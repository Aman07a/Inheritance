using System;

namespace _09___Inheritance
{
    // Child
    internal class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
        }

        // Method to listen to the radio
        public void ListenRadio()
        {
            // First check if the radio is on
            if (IsOn)
            {
                // Listen to radio
                Console.WriteLine("Listening to the radio!");
            }
            else
            {
                // Print error message
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}
