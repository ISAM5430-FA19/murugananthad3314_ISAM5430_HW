using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            //num = 20
            int num = 20;
            //while num >= 1
            while (num >= 1)
            {
                //print num
                WriteLine(num);
                //num = num - 1
                num = num - 1;
            }
            ReadLine();
            
        }
    }
}
