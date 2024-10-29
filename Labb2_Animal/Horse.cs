using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    public class Horse : Animal
    {
        public int Rodeo { get; set; } = 8;
        public Horse()
        {

        }
        public Horse(int rodeo, string name, int age, int numberOfLegs, bool meateater, string habitat, string sound) : base(name, age, numberOfLegs, meateater, habitat, sound)
        {
            Rodeo = rodeo;
        }
        

        public void HowLong()
        {
            Console.WriteLine($"Hur länge skulle du klara av att sitta kvar på hästen under en rodeo? {Rodeo} sekunder.");
        }
    }
}
