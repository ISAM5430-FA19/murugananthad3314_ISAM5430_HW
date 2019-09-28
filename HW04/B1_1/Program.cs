using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumTwo = 0, sumThree = 0;
            //one number
            for(int i=1; i<=5; i++)
            {
                WriteLine(i);
            }

            //Two numbers permutation
            WriteLine("Two numbers Permutation: ");
            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=5; j++)
                {
                    if(i != j)
                    {
                        WriteLine(i + ", " + j + "; ");
                        sumTwo += i * j;
                    }
                }
            }

            WriteLine("Three numbers Permutation: ");
            //Three numbers permutation
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        for (int k = 1; k <= 5; k++)
                        {
                            if (j != k && k != i)
                            {
                                WriteLine(i + ", " + j + ", " + k + "; ");
                                sumThree += i * j * k;
                            } 
                        }
                    }
                }
            }

            WriteLine("Sum of two numbers permutation: " + sumTwo);
            WriteLine("Sum of three numbers permutation: " + sumThree);
            ReadLine();
        }
    }
}
