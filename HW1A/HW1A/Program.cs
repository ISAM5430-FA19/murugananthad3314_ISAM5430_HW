using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number1 => ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number2 => ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operator (+, -, /, *) => ");
            string input3 = Console.ReadLine();

            if (input3 == "+")
            {
                int output = 0;
                output = num1 + num2;
                Console.WriteLine($"{ num1} {input3} {num2} = {output}.");
            }
            else if (input3 == "-")
            {
                int output = 0;
                output = num1 - num2;
                Console.WriteLine($"{ num1} {input3} {num2} = {output}.");
            }
            else if (input3 == "*")
            {
                int output = 0;
                output = num1 * num2;
                Console.WriteLine($"{ num1} {input3} {num2} = {output}.");
            }
            else if (input3 == "/")
            {
                double output = 0.0;
                output = (double)num1 / num2;
                Console.WriteLine($"{ num1} {input3} {num2} = {output}.");
            }

            Console.ReadLine();
        }
    }
}
