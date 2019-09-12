using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1, fact = 1;

            while (num <= 10)
            {
                fact = fact * num;
                if(fact <= 1000)
                    WriteLine(fact);
                num++;
            }
            ReadLine();
        }
    }
}
