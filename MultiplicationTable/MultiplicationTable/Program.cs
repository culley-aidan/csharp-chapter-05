using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to display multiplication table for: ");
            int.TryParse(Console.ReadLine(), out int number);
        }
    }
}
