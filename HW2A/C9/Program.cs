using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            while(num >= 0)
            {
                WriteLine(num);
                if (num == 0)
                    break;
                num = num / 2;
            }
            ReadLine();
        }
    }
}
