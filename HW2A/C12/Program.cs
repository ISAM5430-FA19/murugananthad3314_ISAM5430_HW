using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0, second = 1, i=2;
            Write(first + " " + second + " ");
            while (i < 25)
            {
                int third = first + second;
                Write(third + " ");
                first = second;
                second = third;
                i++;
            }
            ReadLine();
        }
    }
}
