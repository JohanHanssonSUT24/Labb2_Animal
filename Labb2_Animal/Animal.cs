using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    public class Animal
    {
        //Create common properties for the classes
        public string Name { get; set; } = "Jane Doe";
        public int Age { get; set; } = 1;
        public int NumberOfLegs { get; set; } = 2;
        public bool Meateater { get; set; } = true;
        public string Habitat { get; set; } = "Unknow whereabouts";
        public string SoundsLike { get; set; } = "...";

       

        //Constructor for base-class
        public Animal(string name, int age, int numberOfLegs, bool meateater, string habitat, string sound)
        {
            Name = name;
            Age = age;
            NumberOfLegs = numberOfLegs;
            Meateater = meateater;
            Habitat = habitat;
            SoundsLike = sound;
        }
        //Empty constructor to be able to use allready set propertievalues
        public Animal()
        {

        }
        //Vitrual methods to be able to override in each sub-class.
        public virtual void Eat()
        {
            if (Meateater == true)
            {
                Console.WriteLine($"{Name} eats meat!");
            }
            else
            {
                Console.WriteLine($"{Name} dosnt eat meat.");
            }
        }
        public virtual void Sleep()
        {
            Console.WriteLine($"Due to its age of {Age} years old, it must rest. ");
        }
        public virtual void Hunt()
        {
            Console.WriteLine($"With its {NumberOfLegs} legs, it hunts its prey in their natural habitat, {Habitat}.");
        }
        public virtual void MakeSound()
        {           
            Console.WriteLine($"{Name} sounds something like this... {SoundsLike}");
        }
        //Create summary of the choosen animal
        public virtual void PrintAnimal()
        {
            Console.WriteLine("-Animal info-");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Number of legs: {NumberOfLegs}");
            Console.WriteLine($"Is a meateater: {Meateater}");
            Console.WriteLine($"Habitat: {Habitat}");
        }
    }
}
