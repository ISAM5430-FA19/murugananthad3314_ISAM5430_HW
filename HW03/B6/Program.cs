using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue, input = 1, count = 0;
            string output = "";
            WriteLine("Enter the inputs: ");

            while(input > 0)
            {
                count++;
                input = int.Parse(ReadLine());

                if (input < min)
                {
                    min = input;
                }
                
                else if (min * min <= input)
                {
                    output += input + " | ";
                    WriteLine("Count: "+count+"\nOutput: " + output);
                    WriteLine("\nEnter new set: ");
                    input = 1;
                    count = 0;
                    min = int.MaxValue;
                }
                if(count != 0)
                {
                    output += input + ", ";
                }
            }
            WriteLine("\nFinal Output: " + output);
            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }
    }
}
