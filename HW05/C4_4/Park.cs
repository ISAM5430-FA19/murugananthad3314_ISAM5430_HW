using System;
using System.Collections.Generic;
using System.Text;

namespace C4_4
{
    class Park
    {
        public string ParkName { get; private set; }
        public string ParkLocation { get; private set; }

        private string _parktype;
        public string ParkType
        {
            get { return _parktype; }
            set
            {
                if (value.Equals("National") || value.Equals("State") || value.Equals("Local")) _parktype = value;
                //else _parktype = null;
            }
        }

        private decimal _fee;
        public decimal Fee
        {
            get
            {
                return _fee;
            }
            set
            {
                if (value >= 0) _fee = value;
            }
        }

        private int _employeescount;
        public int EmployeesCount
        {
            get
            {
                return _employeescount;
            }
            set
            {
                if (value > 0) _employeescount = value;
                else _employeescount = 0;
            }
        }

        private int _visitorscount;
        public int VisitorsCount
        {
            get
            {
                return _visitorscount;
            }
            set
            {
                if (value > 0) _visitorscount = value;
                else _visitorscount = 0;
            }
        }

        private double _annualbudget;
        public double AnnualBudget
        {
            get
            {
                return _annualbudget;
            }
            set
            {
                if (value > 0) _annualbudget = value;
                else _annualbudget = 0;
            }
        }

        public string ParkFacilities { get; private set; }


        public Park(string pname, string ptype, string plocation, string pfacilities, decimal fee, int empcount, int visicount, double annbudget)
        {
            ParkName = pname;
            ParkType = ptype;
            ParkLocation = plocation;
            ParkFacilities = pfacilities;
            Fee = fee;
            EmployeesCount = empcount;
            VisitorsCount = visicount;
            AnnualBudget = annbudget;
        }
        public string DisplayParkNameTypeLocation()
        {
            return "\nName of the Park: "+ParkName+"\nPark Location: "+ParkLocation+"\nPark Type: "+ParkType;
        }

        public string DisplayParkNameTypeFacility()
        {
            return "\nName of the Park: " + ParkName + "\nPark Location: " + ParkLocation + "\nPark Facility: " + ParkFacilities;
        }

        public double CalculateVisitorCost()
        {
            return (double)AnnualBudget / VisitorsCount;
        }

        public double CalculateRevenue()
        {
            return (double)VisitorsCount * (double)Fee;
        }

        public override string ToString()
        {
            return "\nName of the Park: " + ParkName + "\nPark Location: " + ParkLocation + "\nPark Facility: " + ParkFacilities + "\nPark Type" + ParkType
                    +"\nFee: "+Fee+"\nEmployees Count: "+EmployeesCount+"\nVisitors Count: "+VisitorsCount+"\nAnnual Budget: "+AnnualBudget;
        }

    }
}
