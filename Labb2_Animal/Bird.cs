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

        //public void WillItFly()
        //{
        //    if (CanFly = true)
        //    {
        //        Console.WriteLine("It flew away...");
        //    }
        //    else if ( CanFly = false)
        //    {
        //        Console.WriteLine("Dang it, it died...");
        //    }
        //}
    }
}
