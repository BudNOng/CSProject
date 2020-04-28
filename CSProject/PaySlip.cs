using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CSProject
{
    class PaySlip
    {
        private int _month;
        private int _year;

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
        public void GeneratePaySlip(List<Staff> myStaff)
        {
            string path;

            //foreach loop to go through each of the staff in the List of Staff Class
            foreach(Staff staff in myStaff)
            {
                //Console.WriteLine("\nTest to see that the GeneratePaySlip method is called --> " + staff.NameOfStaff + ".txt");
                path = staff.NameOfStaff + ".txt";

                //write streamwrite class to write to the file at the pathspecified by 'path' variable.
                using (StreamWriter sw = new StreamWriter(path, true)) //true is used to append data. No semi colon ';' when 'using' used
                {
                    sw.WriteLine("\nPAYSLIP FOR {MONTH} {YEAR}", (MonthOfYear) _month, _year); //as _month is an integer, this need to cast it into a MonthsOfYear??
                    sw.WriteLine("=========================================");
                    sw.WriteLine("Name of Staff: {0}", staff.NameOfStaff);
                    sw.WriteLine("HoursW WOrked: {0}", staff.HoursWorked);
                    sw.WriteLine("\nBasic Pay: {0:C}", staff.BasicPay);

                    //if current run time object type is manager then
                    //  print Allowance property in Manager Class
                    //if else
                    //  print Overtime property in Admin CLass
                    if (staff.GetType() == typeof(Manager))
                    {
                        //another casting in ((Manager)staff) bit....need to learn more or visualise how this works
                        //conversion an object reference to its base class reference?
                        //is this up casting or down casting? or is it none? or is this polymorphism? aarrghh
                        sw.WriteLine("allowance: {0:c}", ((Manager)staff).Allowance);
                    }

                    //sw.writeline("allowance: {0:c}", staff.);
                    sw.WriteLine("/n=========================================");
                    sw.WriteLine("\nTotal Pay : ${TotalPay}");
                    sw.WriteLine("=========================================");


                }
            }
        }
    }
}
