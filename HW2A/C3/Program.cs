using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num < 100)
            {
                if (num > 0 && num % 10 == 0)
                {
                    WriteLine(num);
                }
                num++;
            }
            ReadLine();

        }
    }
}
