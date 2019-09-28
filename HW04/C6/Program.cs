using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, countVowels = 0, countConsonants = 0, flag = 0;
            bool checkVowels = false, checkConsonants = false, checkAltVowConst = true, smoothTransition = false, altOrders = false, checkMusical = false, secondHalf = false;
            char prev = ' ', previous = ' ', prevprev = ' ', current = ' ', firstLetter = ' ';
            while (true)
            {
                var keyInfo = Console.ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter)) break;
                
                //Count the vowels and consonants
                if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y')
                {
                    checkVowels = true;
                    checkConsonants = false;
                    countVowels++;
                }

                else
                {
                    checkConsonants = true;
                    checkVowels = false;
                    countConsonants++;
                }

                //Check letters in increasing order
                if (letter > prev && prev != letter)
                    prev = letter;
                else
                    flag = 1;

                //Check to play the word in musical instruments
                if (!(letter >= 'A' && letter <= 'G'))
                    checkMusical = true;

                //Are all the letters in the second half of the alphabet
                if (!(letter >= 'N' && letter <= 'Z'))
                    secondHalf = true;

                //Check if the word alternate between vowels and consonants
                if (count == 0 && checkVowels)
                    firstLetter = 'v';
                else if(count == 0 && checkConsonants)
                    firstLetter = 'c';

                if((firstLetter == 'v' && count % 2 == 0 && checkVowels && checkAltVowConst)||(firstLetter == 'v' && count %2 != 0 && checkConsonants && checkAltVowConst))
                    checkAltVowConst = true;
                else if((firstLetter == 'c' && count % 2 == 0 && checkConsonants && checkAltVowConst) || (firstLetter == 'c' && count % 2 != 0 && checkVowels && checkAltVowConst))
                    checkAltVowConst = true;
                else
                    checkAltVowConst = false;

                //smooth transition
                if (letter - previous == 1 || letter - previous == -1 || letter - previous == 0) smoothTransition = true;
                else smoothTransition = false;

                //Alternating orders
                current = letter;

                if(previous > prevprev && previous > current)
                    altOrders = true;
                else if (previous < prevprev && previous < current)
                    altOrders = true;
                else
                    altOrders = false;

                prevprev = previous;
                previous = current;
                //Count the number of letters entered by the user
                count++;
            }

            WriteLine("\nNumber of chars: "+count);
            WriteLine("\nNumber of vowels: " + countVowels);
            WriteLine("\nNumber of consonants: " + countConsonants);
            if(flag == 0) WriteLine("\nLetters are in increasing order");
            else WriteLine("\nLetters are not in increasing order");
            if (!checkMusical) WriteLine("\nThis word can be played in musical instruments");
            else WriteLine("This word cannot be played in musical instrument");
            if (!secondHalf) WriteLine("\nThe letters are in second half of the alphabets");
            else WriteLine("The letters are not in second half of the alphabets");
            if (checkAltVowConst) WriteLine("\nThe word only alternates between vowels and consonants");
            else WriteLine("The word does not alternates between vowels and consonants");
            if (smoothTransition) WriteLine("\nIts a smooth transition word");
            else WriteLine("Its not a smooth transition word");
            if (altOrders) WriteLine("\nIts in alternating orders");
            else WriteLine("Its not in alternating orders");
            ReadLine();
        }
    }
}
