using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 20 )
            {
                if (num % 2 != 0 && !(num % 3 == 0))
                {
                    WriteLine(num);
                }
                num++;
            }
            ReadLine();
        }
    }
}
