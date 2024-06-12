using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; } = true;
        public bool HasScales { get; set; } = true;
        public bool HasForkedTongue { get; set; } = true;
        public string Water { get; set; }


        public void PrintReptileDetails()
        {
            Console.WriteLine($"Is cold blooded {IsColdBlooded}");
            Console.WriteLine($"Has a scales {HasScales}");
            Console.WriteLine($"Has a forked tongue {HasForkedTongue}");
            Console.WriteLine("Swims in a {Water}");
        }

    }
}