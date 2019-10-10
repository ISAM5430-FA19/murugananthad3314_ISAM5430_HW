using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num = 1;
            int prev = 0;
            WriteLine(num);
            while(num < 100)
            {
                prev = num;
                if ((prev + num).ToString().Length <= 2)
                    WriteLine(prev + num);
                num = prev + num;
            }*/

            int num = 1, prev = 1;
            WriteLine(prev);
            while(num <= 10)
            {
                prev = prev * 2; // prev + prev
                //if ((prev).ToString().Length <= 2)
                if (prev <= 100)
                    WriteLine(prev);
                num++;
            }
            ReadLine();
        }
    }
}
