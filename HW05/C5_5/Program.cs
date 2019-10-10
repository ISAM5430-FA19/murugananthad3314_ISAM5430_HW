using System;

namespace C5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Details for Date: ");
            Console.WriteLine("Enter the Month: [1-12] ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Day: [1-31] ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Year: ");
            int year = int.Parse(Console.ReadLine());

            Date date = new Date(month, day, year);
            Console.WriteLine("Display: " + date.DisplayDate());
        }
    }
}
