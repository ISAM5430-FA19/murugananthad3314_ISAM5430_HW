using System;

namespace B_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name and the balance for account: ");
            string name = Console.ReadLine();
            decimal balance = decimal.Parse(Console.ReadLine());

            Account account = new Account(name, balance);

            Console.WriteLine(account.Name + "'s balance is: " + account.Balance);
            Console.WriteLine("Enter the amount for the deposit: ");
            decimal deposit = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Adding deposit amount to your account...");

            account.Deposit(deposit);

            Console.WriteLine("The current balance is:  "+account.Balance);
            Console.WriteLine("Enter withdrawal amount from your account: ");
            decimal withdraw = decimal.Parse(Console.ReadLine());

            account.WithDraw(withdraw);
            Console.WriteLine("The current balance is:  " + account.Balance);
        }
    }
}
