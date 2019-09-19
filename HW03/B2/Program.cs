//using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, prev = -1;
            Console.WriteLine("Enter a num: ");
            int input = int.Parse(Console.ReadLine());
            while (input != prev)
            {
                prev = input;
                sum += input;
                Console.WriteLine("Enter a num: ");
                input = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("\n\nPress enter to exit...");
            Console.ReadLine();
        }
    }
}
