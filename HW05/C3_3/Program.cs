using System;

namespace C3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Original Amount: ");
            Console.Write("Dollars: ");
            int dollars = int.Parse(Console.ReadLine());
            Console.Write("Cents: ");
            int cents = int.Parse(Console.ReadLine());

            Money money = new Money(dollars, cents);

            Console.Write("Enter decrement amount in dollars: ");
            dollars = int.Parse(Console.ReadLine());
            Console.Write("Enter decrement amount in cents: ");
            cents = int.Parse(Console.ReadLine());
            Console.WriteLine("Original Amount: "+money.Dollars+"."+money.Cents);

            Money dec = money.DecrementMoney(dollars, cents);

            Console.WriteLine("New Dollar Amount: "+dec.Dollars+"."+dec.Cents);

            Console.Write("Enter increment amount in dollars: ");
            dollars = int.Parse(Console.ReadLine());
            Console.Write("Enter increment amount in cents: ");
            cents = int.Parse(Console.ReadLine());
            Console.WriteLine("Original Amount: " + money.Dollars + "." + money.Cents);
            Money inc = money.IncrementMoney(dollars, cents);
            Console.WriteLine("New Dollar Amount: "+inc.Dollars + "." + inc.Cents);

            Console.WriteLine("Amount in various form: " + money.CountAmount());
        }
    }
}
