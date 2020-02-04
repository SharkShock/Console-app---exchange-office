using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exchange_office
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            float exchangerate, USD, EUR;
            Console.WriteLine("Exchange EUR to USD");

            do
            {
                exchangerate = 1.18f;    //actual rate or type your own Convert.ToSingle(Console.ReadLine());
                Thread.Sleep(500);
                Console.WriteLine("Exchange rate today: " + exchangerate);
                Thread.Sleep(500);
                Console.WriteLine("How much would you like to change? ");
                EUR = Convert.ToSingle(Console.ReadLine());
                Thread.Sleep(1000);
                Console.Write("Please wait");
                SlowIt(300, "................");
                Console.WriteLine();
                Thread.Sleep(500);


                USD = EUR * exchangerate;
                Console.WriteLine("You'll recieve " + USD.ToString("0.0 $ "));
                Console.WriteLine("Would you like to exit? [YES/NO] ");

                String a = Console.ReadLine();
                i = string.Compare("yes", a);
            } while (i != 0);

        }


        static void SlowIt(int milsec_delay, string str)
        {
            foreach (char c in str)
            {
                Console.Write(c);
                Thread.Sleep(milsec_delay);
            }

        }
    }
}








