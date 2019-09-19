using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C14
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\n(a)");
            for(int i = 0; i < 10; i++)
            {
                WriteLine();
                for (int j = 0; j < i; j++)
                {
                    Write('*');
                }
            }

            WriteLine("\n(b)");
            for (int i = 10; i > 0; i--)
            {
                WriteLine();
                for (int j = i; j > 0; j--)
                {
                    Write('*');
                }
            }

            WriteLine("\n(c)");
            for (int i = 0; i < 10; i++)
            {
                WriteLine();
                for (int j = 0; j < 10; j++)
                {
                    if (i > 0 && j < i)
                    {
                        Write(' ');
                    }
                    else
                    {
                        Write('*');
                    }    
                }
            }

            WriteLine("\n(D)");
            for (int i = 0; i < 10; i++)
            {
                WriteLine();
                for (int j = 0; j < 10; j++)
                {
                    if (i > 0 && j > 10-(i+1))
                    {
                        Write('*');
                    }
                    else
                    {
                        Write(' ');
                    }
                }
            }

            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }
    }
}
