using System;
using System.Collections.Generic;
using System.Text;

namespace C1_1
{
    class Student
    {
        public int StudentNumber { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Classification { get; private set; }
        public string Major { get; private set; }

        private decimal _gpa;

        public decimal GPA
        {
            get
            {
                return _gpa;
            }
            set
            {
                if (value > 0) _gpa = value;
            }
        }

        public Student(int stuNum, string fname, string lname, string classification, string major)
        {
            StudentNumber = stuNum;
            FirstName = fname;
            LastName = lname;
            Classification = classification;
            Major = major;
        }

        public Student(decimal gpa)
        {
            GPA = gpa;
        }
    }
}
