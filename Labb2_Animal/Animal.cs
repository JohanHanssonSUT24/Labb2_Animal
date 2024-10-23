using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
        public bool Meateater { get; set; }
        public string Habitat { get; set; }
    }

    public Animal Eat()
    {
        Console.WriteLine($"{Name} äter sin mat.");
    }
    public Animal Sleep()
    {
        Console.WriteLine();
    }
    public Animal Hunt()
    {

    }
}
