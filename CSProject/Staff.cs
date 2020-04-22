using System;
using System.Collections.Generic;
using System.Text;

namespace CSProject
{
    class Staff
    {
        //fields
        private float _hourlyRate;
        private int _hWorked;

        //properties
        public int HoursWorked
        {
            get
            {
                return _hWorked;
            }
            set
            {
                if (value > 0)
                    _hWorked = value;
                else
                    _hWorked = 0;
            }
        }
        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }

        //methods
        public virtual void CalculatePay()
        {
            //print out calculate pay..
            Console.WriteLine("\n...Calculating Pay...");

            //then..calculate basic pay with rate*hoursworked
            BasicPay = _hourlyRate * _hWorked;

            //assign basic salary to total pay
            TotalPay = BasicPay;
        }

        //ToString method (to override the predefined ToString) to return a string that represent the current class
        public override string ToString()
        {
            return "\nName of Staff is " + NameOfStaff + ". Current hourly rate is " + _hourlyRate + " and have worked for " + _hWorked;
        }

        //constructors
        public Staff(string name, float rate)
        {
            //initialiaze fieds members
            this.NameOfStaff = name;
            this._hourlyRate = rate;
        }
    }
}
