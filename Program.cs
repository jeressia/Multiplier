using System;

namespace Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a list of numbers separated by commas.");
            var numbers = Console.ReadLine();

            Console.WriteLine($"Your numbers are {numbers}");

            var splitNumbers = numbers.Split(",");

            Console.WriteLine($"Your split numbers look like this: {splitNumbers}");
        }
    }
}
