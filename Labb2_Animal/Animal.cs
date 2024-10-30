using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    public class Animal
    {
        public string Name { get; set; } = "Unknown name";
        public int Age { get; set; } = 1;
        public int NumberOfLegs { get; set; } = 2;
        public bool Meateater { get; set; } = true;
        public string Habitat { get; set; } = "Habitat unknown";
        public string SoundsLike { get; set; } = "Sound unknown";

       


        public Animal(string name, int age, int numberOfLegs, bool meateater, string habitat, string sound)
        {
            Name = name;
            Age = age;
            NumberOfLegs = numberOfLegs;
            Meateater = meateater;
            Habitat = habitat;
            SoundsLike = sound;
        }
        public Animal()
        {

        }
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
        public virtual void PrintAnimal()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Number of legs: {NumberOfLegs}");
            Console.WriteLine($"Is a meateater: {Meateater}");
            Console.WriteLine($"Habitat: {Habitat}");
        }
    }
}
