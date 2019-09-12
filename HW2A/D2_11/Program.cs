using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the count of numbers: ");
            int count = int.Parse(ReadLine());
            int i = 1, temp = 0;
            bool twotwo = false;
            while (i <= count)
            {
                WriteLine("Enter number" + i + ": ");
                int input = int.Parse(ReadLine());
                if (input == 2)
                {
                    if (temp == input)
                    {
                        twotwo = true;
                    }
                    else
                    {
                        twotwo = false;
                    }
                }
                temp = input;
                i++;
            }
            WriteLine("Two two: " + twotwo);
            ReadLine();
        }
    }
}