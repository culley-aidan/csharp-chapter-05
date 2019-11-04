using System;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalAddition = 0;
            bool loop = true;
            while (loop)
            {
                Console.Write("Enter a number: ");
                int.TryParse(Console.ReadLine(), out int numberEntered);
                if (numberEntered != 999) {
                    finalAddition += numberEntered;
                } else {
                    loop = false;
                }
            }
            Console.WriteLine("your final number is: {0}", finalAddition);
        }
    }
}
