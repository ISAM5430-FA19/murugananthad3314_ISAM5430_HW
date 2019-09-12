using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0, count4 = 0, i = 1;
            Console.Write("Enter the count: ");
            int count = int.Parse(ReadLine());
            while (i <= count)
            {
                Write("Enter the number" + i + ": ");
                int input = int.Parse(ReadLine());
                if(input == 1)
                {
                    count1++;
                }
                else if(input == 4)
                {
                    count4++;
                }
                i++;
            }

            if(count1 > count4)
            {
                WriteLine("YES, number of 1's is more than the number of 4's");
            }
            else
            {
                WriteLine("NO, number of 1's is not more than the number of 4's");
            }
            ReadLine();
        }
    }
}
