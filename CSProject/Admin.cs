using System;
using System.Collections.Generic;
using System.Text;

namespace CSProject
{
    class Admin:Staff
    {
        //override method to claculate pay from virtual method in parent class.
        public override void CalculatePay()
        {

        }

        //constructor
        public Admin()
        {
            Console.WriteLine("*-*-*Child Constructor of Admin Child Class*-*-*");
        }
    }
}
