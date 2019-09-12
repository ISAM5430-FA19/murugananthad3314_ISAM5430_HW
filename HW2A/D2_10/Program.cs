using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the count");
            int count = int.Parse(ReadLine());

            int i = 1;
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;

            while (i <= count)
            {
                Write("\nEnter the number" + i + ": ");

                int input = int.Parse(ReadLine());

                if (input > max)
                {
                    max = input;
                }

                if (input < min)
                {
                    min = input;
                }

                sum += input;
                i++;
            }

            sum -= max + min;

            Write("\nCentered Average: " + (double)sum / (count - 2));
            ReadLine();
        }
    }
}
