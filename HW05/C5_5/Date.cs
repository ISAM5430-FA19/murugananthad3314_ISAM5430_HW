using System;
using System.Collections.Generic;
using System.Text;

namespace C5_5
{
    class Date
    {
        private int _month;
        private int _day;
        public int Year { get; private set; }

        public int Month
        {
            get { return _month; }
            set
            {
                if (value >= 1 && value <= 12) _month = value;
            }
        }

        public int Day
        {
            get { return _day; }
            set
            {
                if (value >= 1 && value <= 12) _day = value;
            }
        }

        public Date(int m, int d, int y)
        {
            Month = m;
            Day = d;
            Year = y;
        }

        public string DisplayDate()
        {
            //return Month+"/"+Day+"/"+Year;
            DateTime dt = new DateTime(Year, Month, Day);
            return dt.ToString("d");
        }
    }
}
