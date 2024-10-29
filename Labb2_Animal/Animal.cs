using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    public class Animal
    {
        public string Name { get; set; } = "Ej angivet";
        public int Age { get; set; } = 1;
        public int NumberOfLegs { get; set; } = 2;
        public bool Meateater { get; set; } = true;
        public string Habitat { get; set; } = "djungel";
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
                Console.WriteLine($"{Name} äter kött!");
            }
            else
            {
                Console.WriteLine($"{Name} äter inte kött.");
            }
        }
        public void Sleep()
        {
            Console.WriteLine($"Pga sin ålder om {Age} år så måste hen vila. ");
        }
        public void Hunt()
        {
            Console.WriteLine($"Med sina {NumberOfLegs} ben jagar den sitt byte i sin naturliga miljö, {Habitat}.");
        }
        public void Sounds()
        {
            Console.WriteLine($"{Name} har ett läte som låter såhär {Sound}");
        }

        public void PrintAnimal()
        {
            Console.WriteLine($"Namn: {Name}");
            Console.WriteLine($"Ålder: {Age}");
            Console.WriteLine($"Antal ben: {NumberOfLegs}");
            Console.WriteLine($"Äter kött: {Meateater}");
            Console.WriteLine($"Hemvist: {Habitat}");
            Console.WriteLine($"Läte: {Sound}");
        }
    }
}
