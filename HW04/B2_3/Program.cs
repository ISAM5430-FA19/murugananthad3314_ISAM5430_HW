using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atleast one vowel
            WriteLine("Atleast one vowel");
            for(char a = 'A'; a <= 'H'; a++)
            {
                for (char b = 'A'; b <= 'H'; b++)
                {
                    if(a == 'A' || a == 'E' || b == 'A' || b == 'E')
                        WriteLine(a + "" + b);
                }
            }

            // one consonant and one vowel
            WriteLine("One consonant and one vowel");
            for (char a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a == 'A' || a == 'E';
                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    int vowels = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    if (vowels == 1)
                        WriteLine(a + "" + b);
                }
            }

            // Begin consonant and end vowel
            WriteLine("Begin consonant and end vowel");
            for (char a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a != 'A' && a != 'E';
                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    int vowels = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    if (vowels == 2)
                        WriteLine(a + "" + b);
                }
            }
            ReadLine();
        }
    }
}
