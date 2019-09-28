using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //a) must contain atleast one vowel (DA, DAB, DAD)
            WriteLine("Must contain atleast one vowel");
            for(char a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a == 'A' || a == 'E';
                for(char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    int vowels = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    if (vowels >= 1)
                        WriteLine(a + "" + b);
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c == 'A' || c == 'E';
                        int vowelCCount = (vowelC ? 1 : 0) + vowels;
                        if (vowelCCount >= 1)
                            WriteLine(a + "" + b + "" + c);
                    }
                }
                
            }

            //b) must begin with consonant and end with vowel (BE, BEE, CHA)
            WriteLine("\n\nMust begin with consonant and end with vowel");
            for (char a = 'A'; a <= 'H'; a++)
                {
                    bool vowelA = a != 'A' && a != 'E';
                    for (char b = 'A'; b <= 'H'; b++)
                    {
                        bool vowelB = b == 'A' || b == 'E';
                        int vowels = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                        if (vowels == 2)
                            WriteLine(a + "" + b);
                        for (char c = 'A'; c <= 'H'; c++)
                        {
                            bool vowelC = c == 'A' || c == 'E';
                            int vowelCCount = (vowelC ? 1 : 0) + (vowelA ? 1 : 0);
                            if (vowelCCount == 2)
                                WriteLine(a + "" + b + "" + c);
                        }
                    }

                }

            //c) Middle letter is a vowel and must contain unique characters (BE, BED)
            WriteLine("\n\nMiddle letter is a vowel and must contain unique characters");
            for (char a = 'A'; a <= 'H'; a++)
            {
                char temp = a;
                bool vowelA = a != 'A' && a != 'E';
                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    int vowels = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    if (vowels == 2)
                        WriteLine(a + "" + b);
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c != 'A' && c != 'E';
                        int vowelCCount = (vowelC ? 1 : 0) + vowels;
                        if (vowelCCount == 3 && temp != c)
                            WriteLine(a + "" + b + "" + c);
                    }
                }

            }

            ReadLine();
            }
        }
    }