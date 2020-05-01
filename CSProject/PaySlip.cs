using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

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
        public void GeneratePaySlip(List<Staff> myStaff) //this method doesn't know yet what state is in, we only declare parameter 'myStaff as a List of type Staff'.
        {
            string path;

            //foreach loop to go through each of the Staff in the List of Staff Class
            foreach(Staff staff in myStaff) // <----state that
            {
                //Console.WriteLine("\nTest to see that the GeneratePaySlip method is called --> " + staff.NameOfStaff + ".txt");
                path = staff.NameOfStaff + ".txt";

                //write streamwrite class to write to the file at the pathspecified by 'path' variable.
                using (StreamWriter sw = new StreamWriter(path, true)) //true is used to append data. No semi colon ';' when 'using' used
                {
                    sw.WriteLine("PAYSLIP FOR {0} {1}", (MonthOfYear) _month, _year); //as _month is an integer, this need to cast it into a MonthsOfYear??
                    sw.WriteLine("=========================================");
                    sw.WriteLine("Name of Staff: {0}", staff.NameOfStaff);
                    sw.WriteLine("Hours worked: {0}", staff.HoursWorked);
                    sw.WriteLine("Basic pay: {0:C}", staff.BasicPay);

                    /*  if current run time object type is manager then 
                     *      print Allowance property in Manager Class
                     *  if else
                     *      print Overtime property in Admin Class
                     */

                    if (staff.GetType() == typeof(Manager))
                    {
                        //another casting in ((Manager)staff)
                        //conversion an object reference to its base class reference so it can see the appropriate properties
                        sw.WriteLine("allowance Imbursed: {0:C}", ((Manager)staff).Allowance);
                    }
                    else
                    {
                        //same again here but for if the type of staff is Admin.
                        //then Casting ((Admin)staff).... convert staff type (parent) to admin type (child) to access admin's property. 
                        sw.WriteLine("Overtime Imbursed: {0:C}", ((Admin)staff).Overtime);
                    }

                    sw.WriteLine("=========================================");
                    sw.WriteLine("Total Pay : {0:C}" , staff.TotalPay);
                    sw.WriteLine("=========================================");

                    //close Streamwriter
                    sw.Close();
                }                
            }
        }

        //method to generates a summary of employees who worked < 10 hours in that month.
        public void GenerateSummary(List<Staff> myStaff) //this method doesn't know yet what state is in, we only declare parameter 'myStaff as a List of type Staff'.
        {
            //LINQ to query staff that worked < 10
            //then assign result with ascending order by the name of staff.
            var result = from Staff staff in myStaff // <----states that we're performing query on the myStaff List of type Staff Class
                         where staff.HoursWorked < 10
                         orderby staff.NameOfStaff ascending
                         select new {staff.NameOfStaff, staff.HoursWorked }; //using 'new' keyword, need it whenever we want to return more than one fields/properties from the objects.
            
            //Ienumerable. LEARN!!
            /*var result2 = myStaff.Where(staff => staff.HoursWorked < 10).OrderBy(staff => staff.NameOfStaff);*/
            
            string path = "summary.txt";

            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Staff with less than 10 working hours");

                foreach (var staff in result) //using var keyword instead of Staff as for each cannot recognise the anonymous type from result
                {
                    sw.WriteLine("\nName of staff: {0}, hours worked: {1}", staff.NameOfStaff, staff.HoursWorked);
                }

                sw.Close();
            }
        }

        public override string ToString()
        {
            return "This payslip is for " + _month + "' and year " + _year;
        }
    }
}
