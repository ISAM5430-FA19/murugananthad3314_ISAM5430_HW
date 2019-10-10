using System;

namespace C1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your student ID: ");
            int stuID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your first name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter your classification: ");
            string classification = Console.ReadLine();
            Console.WriteLine("Enter your major: ");
            string major = Console.ReadLine();
            Console.WriteLine("Enter your GPA: ");
            decimal gpa = decimal.Parse(Console.ReadLine());

            Student student = new Student(stuID, fname, lname, classification, major);
            student.GPA = gpa;

            Console.WriteLine("Name of the student: "+student.FirstName+" "+student.LastName);
            Console.WriteLine("GPA: " + student.GPA);
        }
    }
}
