using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the grade (0-4): ");
            decimal gpa = decimal.Parse(ReadLine());
            int flag = 0;
            if (!(gpa >= 0 && gpa <= 4)){
                WriteLine("Invalid GPA");
                flag = 1;
            }
            decimal actual_gpa = (int)(3 * gpa + 0.5m);
            string grade = "";

            if(flag == 0)
            {
                if(actual_gpa > 10)
                {
                    grade = "A";
                    if (actual_gpa < 12)
                    {
                        grade += "-";
                    }
                }
                else if (actual_gpa > 7)
                {
                    grade = "B";
                    if (actual_gpa < 9)
                    {
                        grade += "-";
                    }
                    else if(actual_gpa > 9 && actual_gpa <= 10)
                    {
                        grade += "+";
                    }
                }
                else if (actual_gpa > 4)
                {
                    grade = "C";
                    if (actual_gpa < 6)
                    {
                        grade += "-";
                    }
                    else if (actual_gpa > 6 && actual_gpa <= 7)
                    {
                        grade += "+";
                    }
                }
                else if (actual_gpa > 2)
                {
                    grade = "D";
                    if (actual_gpa > 3 && actual_gpa <= 4)
                    {
                        grade += "+";
                    }
                }
                else
                {
                    grade = "F";
                }
                WriteLine("Grade: " + grade);
            }
            ReadLine();
        }
    }
}
