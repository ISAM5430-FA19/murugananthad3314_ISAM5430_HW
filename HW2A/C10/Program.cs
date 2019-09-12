using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 100;
            while (num >= 1)
            {
                WriteLine(num);
                num = (double)num/2;
            }
            ReadLine();
        }
    }
}
