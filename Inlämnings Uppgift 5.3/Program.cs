using System;

namespace Uppgift5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Skriv in tal nr {i + 1}: ");
                tal[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Summan av talen är: {tal[0] + tal[1] + tal[2]}");
            Console.ReadKey();
        }
    }
}