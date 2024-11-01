﻿using System;
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
        public Tiger()
        {

        }
        //Unique method for the animal
        public void EndangeredAnimal()
        {
            Console.WriteLine($"It is {Endangered} that this animal is endangered!");
        }
        public override void Sleep()
        {
            Console.WriteLine($"The tiger sleeps two thirds of its age, which is {Age}.");
        }       
        public override void MakeSound()
        {
            Console.WriteLine($"The Tiger sounds {SoundsLike}");
        }


    }
}
