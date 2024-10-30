namespace Labb2_Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird(true, "Polly", 22, 2, true, "Woods", "Tweet");
            Bird bird2 = new Bird();

            Console.WriteLine("Animal info:\n");
            bird1.PrintAnimal();
            Console.WriteLine("");
            bird1.MakeSound();
            bird1.Hunt();
            bird1.Sleep();
            Console.WriteLine("");
            Tiger tiger1 = new Tiger(true, "Tigger", 11, 4, true, "djungle", "Roooaaarrr");
            tiger1.MakeSound();
            tiger1.Sleep();
            tiger1.EndangeredAnimal();



        }
    }
}
