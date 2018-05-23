using System;

namespace Justiciar
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Welcome to the Forge!");
            bool done = false;
            do
            {
                Console.WriteLine("I made an item:");
                Console.WriteLine(Forge.ForgeItem());
                Console.Write("Again? (y/n)");
                var userInput = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine("\n");
                done = !userInput.Equals("y");
            } while (!done);
        }
    }
}