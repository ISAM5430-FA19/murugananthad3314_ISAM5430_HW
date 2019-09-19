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
            for(int i=0; i< 5; i++)
            {
                WriteLine();
                for(int j=0; j<5; j++)
                {
                    Write('X');
                }
            }
            WriteLine("\n\nPress Enter to exit...");
            ReadLine();
        }
    }
}
