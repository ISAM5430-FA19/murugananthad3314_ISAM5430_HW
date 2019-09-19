using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            WriteLine("Enter the number to display the prime numbers: ");
            int input = int.Parse(ReadLine());
            WriteLine("\nThe list of prime numbers till " + input + " are: ");

            for(int i=2; i <= input; i++)
            {
                flag = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0) WriteLine(i); 
            }
            WriteLine("Press enter to exit...");
            ReadLine();
        }
    }
}
