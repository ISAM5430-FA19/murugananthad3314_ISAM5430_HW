using System;
using System.Collections.Generic;
using System.Text;

namespace C3_3
{
    class Money
    {
        private int dollars;
        private int cents;

        public int Dollars
        {
            get
            {
                return dollars;
            }
            set
            {
                if (value > 0) dollars = value;
            }
        }

        public int Cents
        {
            get
            {
                return cents;
            }
            set
            {
                /*if (value < 0) throw new ArgumentException("Error: Negative amounts of money are not allowed");
                else
                {*/
                    cents = value;
                //}
            }
        }

        public Money()
        {
            Dollars = 0;
            Cents = 0;
        }

        public Money(int d, int c)
        {
            Dollars = d;
            Cents = c;
        }

        public Money IncrementMoney(int d, int c)
        {
            Money m = new Money();
            Dollars += d;
            Cents += c;
            m.Dollars = Dollars;
            m.Cents = Cents;
            return m;
        }

        public Money DecrementMoney(int d, int c)
        {
            Money m = new Money();
            Dollars -= d;
            Cents -= c;
            m.Dollars = Dollars;
            m.Cents = Cents;
            return m;
        }

        public string CountAmount()
        {
            int countDollars, countQuarters = 0, countNickels = 0, countDimes = 0, countPennies = 0;
            countDollars = Dollars;
            if (Cents >= 100) countDollars += Cents / 100;

            if (Dollars >= 25) countQuarters = Dollars * 4;
            if (Cents >= 25) countQuarters += Cents / 25;
            else countQuarters = 0;

            if (Dollars >= 25) countNickels = Dollars * 20;
            if (Cents >= 25) countNickels += Cents / 5;
            else countNickels = 0;

            if (Dollars >= 25) countDimes = Dollars * 10;
            if (Cents >= 25) countDimes += Cents / 10;
            else countDimes = 0;

            if (Dollars >= 25) countPennies = Dollars * 100;
            if (Cents >= 25) countPennies += Cents;
            else countPennies = 0;
            return "\n\nDollars: " + countDollars + "\nQuarters: " + countQuarters + "\nNickels: " + countNickels + "\nDimes: " + countDimes + "\nPennies: " + countPennies;
        }
        public override string ToString()
        {
            return null;
        }

    }
}
