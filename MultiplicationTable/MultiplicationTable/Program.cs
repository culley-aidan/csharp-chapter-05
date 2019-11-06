using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to display multiplication table for: ");
            int.TryParse(Console.ReadLine(), out int number);
            for (int i = 1; i < 11; ++i)
            {
                Console.WriteLine("{0}*{1}={2}", i, number, i * number);
            }
        }
    }
}
