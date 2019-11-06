using System;

namespace DisplayMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + "\t");
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write(i == 0 ? (j + "\t") : (i * j + "\t"));
                }
                Console.WriteLine();
            }
        }
    }
}
