using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumTwo = 0, sumThree = 0, sumFour = 0, sumFive = 0;
            WriteLine("Two number combination");
            for (int i=1; i<=5; i++)
            {
                for(int j=i+1; j<=5; j++)
                {
                    sumTwo += i * j;
                    WriteLine(i + ", " + j + "; ");
                }
            }

            WriteLine("Three number combination");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for(int k = j + 1; k <= 5; k++)
                    {
                        sumThree += i * j * k;
                        WriteLine(i + ", " + j + ", " + k + "; ");
                    }
                }
            }

            WriteLine("Four number combination");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        for(int x = k + 1; x <= 5; x++)
                        {
                            sumFour += i * j * k * x;
                            WriteLine(i + ", " + j + ", " + k + ", " + x + "; ");
                        }
                    }
                }
            }

            WriteLine("Five number combination");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        for (int x = k + 1; x <= 5; x++)
                        {
                            for(int y = x + 1; y <= 5; y++)
                            {
                                sumFive += i * j * k * x * y;
                                WriteLine(i + ", " + j + ", " + k + ", " + x + ", " + y + "; ");
                            }
                            
                        }
                    }
                }
            }

            WriteLine("Sum of two numbers combination: " + sumTwo);
            WriteLine("Sum of three numbers combination: " + sumThree);
            WriteLine("Sum of four numbers combination: " + sumFour);
            WriteLine("Sum of five numbers combination: " + sumFive);
            ReadLine();
        }
    }
}
