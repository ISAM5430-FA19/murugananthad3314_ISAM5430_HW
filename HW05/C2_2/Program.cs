using System;

namespace C2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the motorway name: ");
            string motorwayname = Console.ReadLine();
            Console.WriteLine("Enter the type: ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the direction:(N/S/E/W) ");
            char direction = char.Parse(Console.ReadLine());
            //if(direction )
            Console.WriteLine("Enter the surface: ");
            string surface = Console.ReadLine();
            Console.WriteLine("Enter the total lanes: ");
            int totlanes = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the party: ");
            string party = Console.ReadLine();
            Console.WriteLine("Enter the toll status:(Y/N) ");
            string tollstat = Console.ReadLine();

            Motorway motor = new Motorway(motorwayname, type, direction, surface, totlanes, party, tollstat);

            Console.WriteLine("The name of the Motorway is: " + motor.DisplayMotorwayName());
            Console.WriteLine("The name of the Motorway and toll status is: " + motor.DisplayNameToll());
            Console.WriteLine("The name of the Motorway and number of lanes is: " + motor.DisplayNameLanes());
            Console.WriteLine("The details of motorway is as follows: ");
            Console.WriteLine(motor);
        }
    }
}
