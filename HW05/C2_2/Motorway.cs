using System;
using System.Collections.Generic;
using System.Text;

namespace C2_2
{
    class Motorway
    {
        private char _direction;
        private int _totlanes;
        public string MotorwayName { get; private set; }
        public string Type { get; private set; }
        public string Surface { get; private set; }
        public string Party { get; private set; }
        private string _tollStatus;

        public char Direction
        {
           get
            {
                return _direction;
            }
            set
            {
                if (value == 'N' || value == 'S' || value == 'E' || value == 'W') _direction = value;
            }
        }

        public int TotalLanes
        {
            get
            {
                return _totlanes;
            }
            set
            {
                if (value > 0) _totlanes = value;
            }
        }
        public string TollStatus
        {
            get
            {
                return _tollStatus;
            }
            set
            {
                if (value == "y" || value == "Y")
                    _tollStatus = "Toll";
                else _tollStatus = "No toll";
            }
        }

        public Motorway(string motorwayname, string type, char dir, string surface, int totLanes, string party, string tollstat)
        {
            MotorwayName = motorwayname;
            Type = type;
            Direction = dir;
            Surface = surface;
            TotalLanes = totLanes;
            Party = party;
            TollStatus = tollstat;
        }

        public string DisplayMotorwayName()
        {
            return MotorwayName;
        }

        public string DisplayNameToll()
        {
            return $"{MotorwayName}\n {TollStatus}";
        }

        public string DisplayNameLanes()
        {
            return $"{MotorwayName}\n {TotalLanes}";
        }

        public override string ToString()
        {
            return $"{MotorwayName}\n{Type}\n{Direction}\n{Surface}\n{TotalLanes}\n{Party}\n{TollStatus}";
        }
    }
}
