namespace Labb2_Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Create different animal objects.
            Bird bird1 = new Bird(true, "Polly", 22, 2, true, "Woods", "Tweet");
            Bird bird2 = new Bird();
            //Print different methods
            bird1.PrintAnimal();
            Console.WriteLine();
            bird1.WillItFly();
            bird1.MakeSound();
            bird1.Hunt();
            Console.WriteLine("");
            bird2.PrintAnimal();
            Console.WriteLine("");

            Tiger tiger1 = new Tiger(true, "Tigger", 11, 4, true, "Djungle", "Roooaaarrr");

            tiger1.PrintAnimal();
            Console.WriteLine("");
            tiger1.MakeSound();
            tiger1.Sleep();
            tiger1.EndangeredAnimal();
            tiger1.Eat();
            tiger1.Hunt();
            Console.WriteLine("");

            Horse horse1 = new Horse(6, "Shadowfax", 8, 4, false, "Middleearth", "Ehhiiiihh");

            horse1.PrintAnimal();
            horse1.HowLong();
            horse1.MakeSound();
            Console.WriteLine("");
            
            Horse_Subclass1 HorseSub1 = new Horse_Subclass1(true, 66, "Holly", 13, 4, false, "Dessert", "Eiiiiihhh");

            HorseSub1.PrintAnimal();
            HorseSub1.Shoes();
            HorseSub1.MakeSound();
            Console.WriteLine("");

            Horse_Subclass2 HorseSub2 = new Horse_Subclass2(10, 5, "Cactus", 89, 3, false, "Soon to be graveyard", "Zzz");

            HorseSub2.PrintAnimal();
            HorseSub2.MakeSound();
            HorseSub2.Drinking();
        }
    }
}
