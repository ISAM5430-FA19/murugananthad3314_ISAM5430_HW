using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter first number: ");
            int first = int.Parse(ReadLine());
            WriteLine("Enter second number: ");
            int second = int.Parse(ReadLine());
            int third = first + second;
            int rev = 0;
            while(third > 0)
            {
                rev = (rev * 10) +(third % 10);
                third = third / 10;
            }
            WriteLine("Reversed number is: " + rev);
            WriteLine("Press enter to exit...");
            ReadLine();
        }
    }
}
