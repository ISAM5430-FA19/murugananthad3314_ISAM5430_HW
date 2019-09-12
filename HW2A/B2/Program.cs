using static System.Console;
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
            Write("Enter number1: ");
            int num1 = int.Parse(ReadLine());
            Write("Enter number2: ");
            int num2 = int.Parse(ReadLine());
            Write("Enter number3: ");
            int num3 = int.Parse(ReadLine());

            if ((num3 > num1 && num1 > num2) || (num2 > num1 && num1 > num3))
            {
                WriteLine("Number1 is the middle number");
            }

            else if((num1 > num2 && num2 > num3) || (num3 > num2 && num2 > num1))
            {
                WriteLine("Number2 is the middle number");
            }

            else
            {
                WriteLine("Number3 is the middle number");
            }
            ReadLine();
        }
    }
}
