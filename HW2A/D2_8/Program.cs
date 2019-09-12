using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the count of numbers: ");
            int count = int.Parse(ReadLine());
            int i = 1, prev = 0, countClump = 0;
            bool flag = true;
            while (i <= count)
            {
                WriteLine("Enter the number" + i + ": ");
                int input = int.Parse(ReadLine());

                if (input == prev && flag)
                {
                    flag = false;
                    countClump++;
                }
                else if(input != prev)
                {
                    flag = true;
                }
                prev = input;
                i++;
            }

            WriteLine("Number of clumps: " + countClump);
            ReadLine();

        }
    }
}
