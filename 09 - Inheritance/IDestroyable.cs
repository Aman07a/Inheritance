using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Inheritance
{
    internal interface IDestroyable
    {
        // Property to store the audio of the destruction sound
        string DestructionSound { get; set; }

        // Method to destroy an object
        void Destroy();
    }
}
