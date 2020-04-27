using System;
using System.Collections.Generic;
using System.Text;

namespace CSProject
{
    class PaySlip
    {
        private int _month, _year;

        enum MonthOfYear // enum declared inside of a class has private access modifier by default.
        {
            JAN=1, FEB=2, MAR=3, APR=4, MAY=5, JUN=6, JUL=7, AUG=8, SEP=9, OCT=10, NOV=11, DEC=12
        }

        public PaySlip(int payMonth, int payYear)
        {
            this._month = payMonth;
            this._year = payYear;
        }

        // method for Generating pay slip which "takes in a list of Staff objects" and does not return anything.
        public void GeneratePaySlip()
        {

        }
    }
}
