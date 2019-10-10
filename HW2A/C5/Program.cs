using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num < 10)
            {
                //if ((int)Math.Pow(num,2).ToString().Length == 2){
                int value = num * num;
                if (value > 10 && value < 100)
                {
                    WriteLine(value);
                }
                num++;
            }

            ReadLine();
        }
    }
}
