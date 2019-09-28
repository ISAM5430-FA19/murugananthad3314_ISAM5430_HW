using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Good condition: inferno: 3, above: 2, called: 1, changed: 1, leaves: 1, syllable: 3
            int count = 0;
            bool prevWasVowel = false;
            char prev = '\0', prevprev = '\0';
            while (true)
            {
                var keyInfo = Console.ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                
                if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y')
                {
                    if (!prevWasVowel) count++;
                    prevWasVowel = true;
                }
                else
                    prevWasVowel = false;
                
                if (!char.IsLetter(letter))
                {
                    if (((prev == 'E') || (prev == 'S' && prevprev == 'E') || (prev == 'D' && prevprev == 'E')) && (!(prev == 'E' && prevprev == 'L')))
                    count--;
                        
                    Console.WriteLine("\n\nSyllable Count: "+count);
                    break;
                }
                prevprev = prev;
                prev = letter;
            }
            Console.ReadLine();
        }
    }
}
