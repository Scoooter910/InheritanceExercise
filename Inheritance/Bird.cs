using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool HasFeathers { get; set; } = true;
        public bool HasBeak { get; set; } = true;
        public string Sound { get; set; } 
        public bool EatsFish { get; set; } = true;

        public void PrintBirdDetails()
        {
            Console.WriteLine($"Has feathers {HasFeathers}");
            Console.WriteLine($"Has beak {HasBeak}");
            Console.WriteLine($"Makes the {Sound}");
            Console.WriteLine($"Eats fish");
        }
    }
}
