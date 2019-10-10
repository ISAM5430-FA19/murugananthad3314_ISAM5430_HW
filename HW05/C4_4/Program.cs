using System;

namespace C4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Park Details: ");
            Console.WriteLine("Enter the Park Name: ");
            string parkname = Console.ReadLine();
            Console.WriteLine("Enter the Park Location: ");
            string parklocation = Console.ReadLine();
            Console.WriteLine("Enter the Park Type: ");
            string parktype = Console.ReadLine();
            Console.WriteLine("Enter the Park Facility: ");
            string parkfacility = Console.ReadLine();
            Console.WriteLine("Enter the Park Fee: ");
            decimal parkfee = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employees Count: ");
            int employeescount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number of visitors for past 12 months: ");
            int visitorscount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Annual Budget: ");
            double annualbudget = double.Parse(Console.ReadLine());

            Park park = new Park(parkname, parktype, parklocation, parkfacility, parkfee, employeescount, visitorscount, annualbudget);

            Console.WriteLine("\nDisplay1: "+park.DisplayParkNameTypeLocation());
            Console.WriteLine("\nDisplay2: "+park.DisplayParkNameTypeFacility());
            Console.WriteLine("\nCalculate cost per visitor: " + park.CalculateVisitorCost());
            Console.WriteLine("\nCalculate revenue fees for last year: " + park.CalculateRevenue());

            Console.WriteLine("Details about the park: " + park);
        }
    }
}
