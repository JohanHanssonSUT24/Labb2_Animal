namespace Labb2_Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal ani1 = new Animal("Björn", 24, 4, true, "Skogen", "ROOOOOAAAAARRR");
            ani1.PrintAnimal();
            ani1.Hunt();
            ani1.Eat();

            Horse horse1 = new Horse();
            horse1.Eat();
            horse1.Sleep();
            horse1.HowLong();

            

        }
    }
}
