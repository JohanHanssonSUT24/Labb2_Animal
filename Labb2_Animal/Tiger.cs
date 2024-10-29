using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    public class Tiger : Animal
    {
        public bool Endangered { get; set; } = true;

        public Tiger(bool endangered, string name, int age, int numberOfLegs, bool meateater, string habitat, string sound ): base (name, age, numberOfLegs, meateater, habitat, sound)
        {
            Endangered = endangered;
        }
        
        public void EndangeredAnimal()
        {
            if (true)
            {
                Console.WriteLine("Vi måste rädda detta djur!");
            }
            else
            {
                Console.WriteLine("Det är lugnt, panga på bara!");
            }
        }

        
    }
}
