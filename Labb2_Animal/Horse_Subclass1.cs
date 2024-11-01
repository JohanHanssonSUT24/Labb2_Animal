using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    internal class Horse_Subclass1 : Horse
    {
        public bool NewShoes { get; set; } = false;
        public Horse_Subclass1(bool newshoes, int rodeo, string name, int age, int numberOfLegs, bool meateater, string habitat, string sound): base(rodeo,name, age, numberOfLegs, meateater, habitat, sound)
        {
            NewShoes = newshoes;
        }
        public Horse_Subclass1()
        {

        }
        //Unique method for the animal
        public void Shoes()
        {
            Console.WriteLine($"Does this horse need new shoes? {NewShoes} ");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"When {Name} gets stung by a bee she makes this sound {SoundsLike}");
        }
    }
}
