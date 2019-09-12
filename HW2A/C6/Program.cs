using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    class Program
    {
        static void Main(string[] args)
        {
            //num = 1;
            int num = 1;
            //while num <= 100
            while (num <= 100)
            {
                //if num is not divisible by 3 or 5 -- makes no sense
                //if num % 3 is not 0 and num % 5 is not 0 or (num % 3 is 0 and num % 5 is 0)
                if ((num % 3 != 0 && num % 5 != 0) || (num % 3 == 0 && num % 5 == 0))
                {
                    //print num
                    WriteLine(num);
                }
                //num = num + 1
                num = num + 1;
            }
            ReadLine();

        }
    }
}
