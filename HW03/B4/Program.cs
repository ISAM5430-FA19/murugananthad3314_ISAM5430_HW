using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4
{
    /* Create a console application that allows user to enter a sequence of three positive sides numbers,
     * side1, side2, side3. The app will terminate when the user enters a zero or a negative number. 
     * In each iteration, the app will print whether the triangle with three sides (side1, side2, side3) is valid.
     * A triangle is valid as long as the sum of any two sides is greter than the other side. 
     * For example, if side1 = 3, side2 = 2, side 3 = 1, it is not a valid triangle because 1+2 != 3. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the three sides of triangle: ");
            int side1 = int.Parse(ReadLine());
            int side2 = int.Parse(ReadLine());
            int side3 = int.Parse(ReadLine());
            while (side1 > 0 && side2 > 0 && side3 > 0)
            {
                if ((side1 + side2 > side3) && (side2 + side3 > side1) && (side1 + side3 > side2))
                {
                    WriteLine("Valid triangle");
                }
                else
                {
                    WriteLine("Invalid triangle");
                }
                WriteLine("Enter the three sides of triangle: ");
                side1 = int.Parse(ReadLine());
                side2 = int.Parse(ReadLine());
                side3 = int.Parse(ReadLine());
            }

            WriteLine("Press enter to exit..");
            ReadLine();
            
        }
    }
}
