using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bestScore = int.MinValue;
            int count = 0, sum = 0;
            double average = 0;
            WriteLine("Enter the score: ");
            int score = int.Parse(ReadLine());
            while(score >=0 && score <= 100)
            {
                count++;
                sum += score;
                if(score > bestScore)
                {
                    bestScore = score;
                }
                WriteLine("Enter the score: ");
                score = int.Parse(ReadLine());
                /*if(score.ToString() == null)
                {
                    WriteLine("User has not entered the score");
                    break;
                }*/
            }
            if(count > 0)
            {
                average = (double)sum / count;
                WriteLine("Best score: " + bestScore);
            }
            else
            {
                WriteLine("Invalid score!!!");
            }
            ReadLine();
        }
    }
}
