using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class D1_codes
    {
        static void Main(string[] args)
        {
            Write("Enter the count: ");
            int count = int.Parse(ReadLine());

            int i = 1, countZeros = 0, countEven = 0, half = count/2, firstHalf = 0, secondHalf = 0, temp = 0;
            bool check = true;
            int max = int.MinValue;
            int min = int.MaxValue;
            string str = "";
            int skipPointer = half + 1;
            WriteLine("skip"+skipPointer);

            while (i <= count)
            {
                Write("Enter the number" + i + ": ");
                //input num
                int input = int.Parse(ReadLine());
                
                //D.1.1 Print positive numbers
                if (input > 0)
                {
                    str += input + " ";
                }

                //D.1.2 Display number of zeros
                if(input == 0)
                {
                    countZeros++;
                }
                
                //D.1.3 Display number of even integers
                if(input %2 == 0)
                {
                    countEven++;
                }

                //D.1.4 Display numbers in increasing order
                if (input > temp && check == true)
                {
                    temp = input;
                }
                else
                {
                    check = false;
                }

                //D.1.5 Largest number
                if (input > max)
                {
                    max = input;
                }

                //D.1.6 Smallest number
                if (input < min)
                {
                    min = input;
                }

                //D.1.7 Check First half = Second Half
                if(i <= half)
                {
                    firstHalf += input;
                }
                else if(count % 2 != 0 && i != skipPointer)
                {
                    secondHalf += input;
                }
                else if (count % 2 == 0)
                {
                    secondHalf += input;
                }
                i++;
            }

            //D.1.1 Print positive numbers
            WriteLine("\nThe positive numbers are: " + str);

            //D.1.2 Display number of zeros
            WriteLine("The number of zeros is: " + countZeros);

            //D.1.3 Display number of even integers
            WriteLine("The number of even integers is: " + countEven);

            //D.1.4 Display numbers in increasing order
            if (check)
            {
                WriteLine("The number are in increasing order");
            }
            else
            {
                WriteLine("The number are not in increasing order");
            }

            //D.1.5 Largest number
            //print out maximum value with commas and no decimal places (0).
            WriteLine($"The largest num is {max:N0}");

            //D.1.6 Smallest number
            WriteLine($"The smallest num is {min:N0}");

            //D.1.7 Check First half = Second Half
            if (firstHalf == secondHalf)
            {
                WriteLine("YES, the sum of firsthalf is same as secondhalf");
            }
            else
            {
                WriteLine("NO, the sum of firsthalf is not same as secondhalf");
            }
            
            ReadLine();
        }
    }
}
