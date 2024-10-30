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
        public override void makeSound(string soundsLike)
        {
            Console.WriteLine($"{Name} sounds like this {soundsLike}");
        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Number of legs: {NumberOfLegs}");
            Console.WriteLine($"Is a meateater: {Meateater}");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Sound: {SoundsLike}");
        }
        public override void Hunt()
        {
            Console.WriteLine($"With its {NumberOfLegs} legs, it hunts its prey in their natural habitat, {Habitat}.");
        }
        public override void Sleep()
        {
            Console.WriteLine($"Due to its age of {Age} years old, it must rest. ");
        }
    }
}
