using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _09___Inheritance.Exercises
{
    // Place for your classes and an interface
    // class Gun : Weapon, IShootable
    // {
    //     public void Shoot()
    //     {
    //         System.Console.WriteLine("Bang!");
    //     }

    //     public Gun()
    //     {
    //         Name = "Gun";
    //     }
    // }

    // interface IShootable
    // {
    //     void Shoot();
    // }

    // class Weapon
    // {
    //     public string Name;

    //     public void Label()
    //     {
    //         System.Console.WriteLine("This is {0}!", Name);
    //     }
    // }

    internal class Exercise11
    {
        static public void Test(string[] args)
        {
            // // New instance
            // Gun pist = new Gun();

            // // Test for methods
            // pist.Label();
            // pist.Shoot();

            // // Verifying the interface and the parent class
            // if (pist is IShootable && pist is Weapon)
            //     System.Console.WriteLine("Yes, it is my parents.");
        }
    }
}
