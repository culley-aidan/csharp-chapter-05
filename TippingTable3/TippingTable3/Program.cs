using System;

namespace TippingTable3
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinnerPrice = 10.00;
            double tipRate;
            double tip;
            double LOWRATE = 0.10;
            double MAXRATE = 0.25;
            double TIPSTEP = 0.05;
            double MAXDINNER = 100.00;
            double DINNERSTEP = 10.00;

            Console.Write("Enter lowest tipping percentage: ");
            double.TryParse(Console.ReadLine(), out LOWRATE);
            Console.Write("Enter highest tipping percentage: ");
            double.TryParse(Console.ReadLine(), out MAXRATE);
            Console.Write("Enter the lowest bill: ");
            double.TryParse(Console.ReadLine(), out DINNERSTEP);
            Console.Write("Enter the highest bill: ");
            double.TryParse(Console.ReadLine(), out MAXDINNER);

            Console.Write("{0, 8}", "Price");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
            {
                Console.Write("{0, 8}", tipRate.ToString("F"));
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            tipRate = LOWRATE;
            while(dinnerPrice <= MAXDINNER)
            {
                Console.Write("{0, 8}", dinnerPrice.ToString("C"));
                while(tipRate <= MAXRATE)
                {
                    tip = dinnerPrice * tipRate;
                    Console.Write("{0, 8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                Console.WriteLine();
            }
        }
    }
}
