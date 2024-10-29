using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    public class Animal
    {
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = 1;
        public int NumberOfLegs { get; set; } = 2;
        public bool Meateater { get; set; } = true;
        public string Habitat { get; set; } = "Jungle";
        public string Sound { get; set; } = "Roooaaaarr";


        public Animal(string name, int age, int numberOfLegs, bool meateater, string habitat, string sound)
        {
            Name = name;
            Age = age;
            NumberOfLegs = numberOfLegs;
            Meateater = meateater;
            Habitat = habitat;
            Sound = sound;
        }
        public Animal()
        {

        }
        public void Eat()
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
        public void Sleep()
        {
            Console.WriteLine($"Due to its age of {Age} years old, it must rest. ");
        }
        public void Hunt()
        {
            Console.WriteLine($"With its {NumberOfLegs} legs, it hunts its prey in their natural habitat, {Habitat}.");
        }
        public void Sounds()
        {
            Console.WriteLine($"{Name} sounds like this {Sound}");
        }

        public void PrintAnimal()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Number of legs: {NumberOfLegs}");
            Console.WriteLine($"Is a meateater: {Meateater}");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Sound: {Sound}");
        }
    }
}
