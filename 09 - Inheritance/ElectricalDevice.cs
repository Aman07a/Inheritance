using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Inheritance
{
    // Parent - Base
    internal class ElectricalDevice
    {
        // Boolean to determine the state of the Electrical Device
        public bool IsOn { get; set; }
        // String for the brand name of the Electrical Device
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        // Switch on the Electrical Device
        public void SwitchOn()
        {
            IsOn = true;
        }

        // Switch off the Electrical Device
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
