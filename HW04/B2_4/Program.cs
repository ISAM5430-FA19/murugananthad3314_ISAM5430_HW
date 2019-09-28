using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atleast one vowel
            WriteLine("Atleast one vowel");
            for (char a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a == 'A' || a == 'E';
                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c == 'A' || c == 'E';
                        int vowels = (vowelA ? 1 : 0) + (vowelB ? 1 : 0) + (vowelC ? 1 : 0);
                        if (vowels >= 1)
                            WriteLine(a + "" + b + "" +c);
                    }
                }
            }

            // Middle letter vowel
            WriteLine("\nMiddle letter vowel");
            for (char a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a != 'A' && a != 'E';
                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c != 'A' && c != 'E';
                        int vowels = (vowelA ? 1 : 0) + (vowelB ? 1 : 0) + (vowelC ? 1 : 0);
                        if (vowels == 3)
                            WriteLine(a + "" + b + "" + c);
                    }
                }
            }

            //Atleast one consonant and one vowel
            WriteLine("\nAtleast one consonant and one vowel");
            for (char a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a == 'A' || a == 'E';
                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c == 'A' || c == 'E';
                        int vowels = (vowelA ? 1 : 0) + (vowelB ? 1 : 0) + (vowelC ? 1 : 0);
                        if (vowels == 1 || vowels == 2)
                            WriteLine(a + "" + b + "" + c);
                    }
                }
            }

            //Middle letter is a vowel with unique characters
            WriteLine("\nMiddle letter is a vowel with unique characters");
            for (char a = 'A'; a <= 'H'; a++)
            {
                char temp = a;
                bool vowelA = a != 'A' && a != 'E';
                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c != 'A' && c != 'E';
                        int vowels = (vowelA ? 1 : 0) + (vowelB ? 1 : 0) + (vowelC ? 1 : 0);
                        if (vowels == 3 && temp != c)
                            WriteLine(a + "" + b + "" + c);
                    }
                }
            }
            ReadLine();
        }
    }
}
