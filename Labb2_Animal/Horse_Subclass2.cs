using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    internal class Horse_Subclass2 : Horse
    {
        public int Water { get; set; } = 3;

        public Horse_Subclass2()
        {

        }

        public Horse_Subclass2(int water, int rodeo, string name, int age, int numberOfLegs, bool meateater, string habitat, string sound): base(rodeo, name, age, numberOfLegs, meateater, habitat, sound)
        {
            Water = water;
        }
        public void Drinking()
        {
            Console.WriteLine($"Hästen dricker {Water} liter vatten varje dag.");
        }
    }
}
