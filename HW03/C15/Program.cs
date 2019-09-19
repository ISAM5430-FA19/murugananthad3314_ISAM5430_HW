using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Input the number: ");
            int input = int.Parse(ReadLine());
            if(input >= 0)
            {
                for (int i = 0; i < input; i++)
                {
                    WriteLine();
                    for (int j = 0; j <= i; j++)
                    {
                        WriteLine(j + 1);
                    }
                }
                WriteLine("Sum: " + input * ((input + 1) / 2));
            }
            
            WriteLine("\nPress enter to exit...");
            ReadLine();

        }
    }
}
