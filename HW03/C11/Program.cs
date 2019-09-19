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
            for (int i = 0; i < 10; i++)
            {
                WriteLine();
                for (int j = 0; j < 10; j++)
                {
                    if(i == 0 && j == 0)
                        Write('X' + "\t");
                    else if (i == 0)
                        Write(j + "\t");
                    else if (j == 0)
                        Write(i + "\t");
                    else
                        Write(i * j + "\t");
                }
            }
            WriteLine("\n\nPress Enter to exit...");
            ReadLine();
        }
    }
}
