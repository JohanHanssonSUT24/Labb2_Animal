using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    public class Bird : Animal
    {
        public bool CanFly { get; set; } = true;
        public Bird(bool canfly, string name, int age, int numberOfLegs, bool meateater, string habitat, string sound) : base(name, age, numberOfLegs, meateater, habitat, sound)
        {
            CanFly = canfly;
        }
        public Bird()
        {

        }

        public void WillItFly()
        {
            Console.WriteLine($"It is {CanFly} that this bird will fly if you throw it of a cliff...");
        }
    }
}
