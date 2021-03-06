﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSProject
{
    class Manager:Staff
    {
        //fields
        private const float _managerHourlyRate = 50;

        //properties
        public int Allowance { get; private set; }

        //constructor
        public Manager(string name)
            :base(name, _managerHourlyRate)
        {

        }

        //overide method CalculatePay from virtual method in parent class
        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 1000;

            //if hours wrked is more than 160
            if (HoursWorked > 160)
            {
                //add allowance to total pay
                Console.WriteLine("\nThis Manager has worked more than 160 hours. Adding allowance of 1000");
                TotalPay += Allowance;
                Console.WriteLine("\nNew Total Pay is: {0}", TotalPay);
            }
                
        }

        //override ToString method
        public override string ToString()
        {
            return "\nChild constructor - This is Object of Manager, " + NameOfStaff +
                ",\nwith hourly rate of " + _managerHourlyRate + "/hour -" +
                "\nthis manager have worked for " + HoursWorked + " hours" +
                "\nTotal pay for this Manager Staff is " + TotalPay +
                "\n================= END =================";
        }
    }
}
