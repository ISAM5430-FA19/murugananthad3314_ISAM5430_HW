using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal principal = 1000;
            decimal amount = principal;
            decimal rate = 0.05m;
            for(int year=0; year <= 10; year++)
            {
                amount = amount + amount * rate;
                WriteLine($"{year,2}.{amount:c}");
            }

            WriteLine("\n\nEnter the rate: ");
            decimal userRate = decimal.Parse(ReadLine());
            WriteLine("Enter the year: ");
            int userYear = int.Parse(ReadLine());
            WriteLine("\n");
            principal = 1000;
            amount = principal;
            for (int i = 0; i <= userYear; i++)
            {
                amount = amount + amount * userRate;
                WriteLine($"{i,2}.{amount:c}");
            }


            WriteLine("\nBelow details for rate from 5 to 10 !!!");
            for (int newRate = 5; newRate <= 10; newRate++)
            {
                principal = 1000;
                amount = principal;
                Console.WriteLine("\nRate"+newRate+": ");
                for (int year = 0; year <= 10; year++)
                {
                    amount = amount + amount * newRate;
                    WriteLine($"{year,2}.{amount:c}");
                }
            }
            

            WriteLine("\n\n Press enter to exit...");
            ReadLine();
        }
    }
}
