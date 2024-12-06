using System;
namespace randomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            double randomNumber = random.NextInt64();

            Console.WriteLine($"Random number: {randomNumber}");
        }


    }
}

