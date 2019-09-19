using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7
{
    class Program
    {
        static void Main(string[] args)
        {
            int rev = 0;
            WriteLine("Input number: ");
            int num = int.Parse(ReadLine());
            while(num > 0)
            {
                rev = (rev * 10) + (num % 10);
                num = num / 10;
            }
            WriteLine("Reversed number is: " + rev);
            WriteLine("\nPress enter to exit...");
            ReadLine();
        }
    }
}
