using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int c = 97;
            while (c < 123)
            {
                Write((char)c);
                c++;
            }*/

            char a = 'a';
            while(a <= 'z')
            {
                Write(a);
                a++;
            }
            ReadLine();
        }
    }
}
