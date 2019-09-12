using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            //print enter the first number
            WriteLine("Enter the first num");
            //input the first number
            int first = int.Parse(ReadLine());
            //print enter the second number
            WriteLine("Enter the second num");
            //input the second number
            int second = int.Parse(ReadLine());
            //if the first number > secoond
            if(first > second)
            {
                //print the first num
                WriteLine(first);
            }
            //else if the second num > first num
            else if(second > first)
            {
                WriteLine(second);
                //print second num
            }
            //else
            else
            {
                WriteLine("both are same");
                //print both the num
            }

        }
    }
}
