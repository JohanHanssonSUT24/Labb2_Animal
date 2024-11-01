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
        //Unique method for the animal
        public void HowLong()
        {
            Console.WriteLine($"For how long would you last on a Rodeo-horse? {Rodeo} seconds.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"A typical horse sounds like {SoundsLike}");
        }
    }
}
