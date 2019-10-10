using System;
using System.Collections.Generic;
using System.Text;

namespace B_1
{
    class Account
    {
        private decimal _balance;
        public string Name
        { get; private set; }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if(value > 0)
                {
                    _balance = value;
                }
            }
        }

        public Account(string N, decimal D)
        {
            Name = N;
            Balance = D;
        }

        public decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                return Balance;
            }
            Balance += amount;

            return Balance;
        }

        public decimal WithDraw(decimal amount)
        {
            if(Balance < amount)
            {
                throw new ArgumentException("Withdrawal amount exceeded account balance");
            }
            Balance -= amount;
            return Balance;
        }
    }
}
