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
            WriteLine("Enter a number: ");
            int count = int.Parse(ReadLine());
            int sum = 0, i = 1;
            double average;
            while(i <= count)
            {
                WriteLine("Enter number" + i+": ");
                int input = int.Parse(ReadLine());
                sum = sum + input;
                i++;
            }

            average = (double)sum / count;
            WriteLine("Sum: " + sum);
            WriteLine("Average: " + average);
            ReadLine();
        }
        
    }
}
