using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            int closest = int.MaxValue, closestInput = 0, distance = 0;
            WriteLine("Enter the item: ");
            int item = int.Parse(ReadLine());
            WriteLine("Enter the Input: ");
            int input = int.Parse(ReadLine());
            while (input != item)
            {
                if(item > input)
                    distance = item - input;
                else
                    distance = input - item;

                if (distance < closest)
                {
                    closest = distance;
                    closestInput = input;
                }
                WriteLine("\nClosest Input: " + closestInput);

                WriteLine("Enter the number: ");
                input = int.Parse(ReadLine());
            }
            WriteLine("Press enter to exit...");
            ReadLine();
        }
    }
}
