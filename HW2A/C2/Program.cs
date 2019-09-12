using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(num <= 10)
            {
                if (num > 0 && num % 2 == 0)
                {
                    WriteLine(num);
                }
                num++;
            }
            ReadLine();
        }
    }
}
