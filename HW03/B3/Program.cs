using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            WriteLine("Enter a value: ");
            int value = int.Parse(ReadLine());
            while(value > max)
            {
                max = value;
                WriteLine("Enter a value: ");
                value = int.Parse(ReadLine());
            }
            WriteLine("Largest value: " + max);
            ReadLine();
        }
    }
}
