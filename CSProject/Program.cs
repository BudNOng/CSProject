using System;
using System.Collections.Generic;

namespace CSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Staff> myStaff = new List<Staff>(); // create new List of type Staff Class object
            FileReader fr = new FileReader(); // create a new FileReader Class object

            // Initialised variable for month & year 
            int month = 0;
            int year = 0;

            // prompt user to enter year.
            // while year is zero.
            //  keep - prompting user.
            //   assign year to the inserted year.
            //    try to catch exception if blank is inserted.
            while (year == 0)
            {
                Console.WriteLine("\nPlease enter the year...");
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You have entered {0}.", year);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Please the correct value of year. E.g.,. 1999, 2002, 2020 etc...");
                    Console.WriteLine("================================================================");
                }
            }

            // prompt user to enter month. 
            // while month is zero. keep - prompting user.
            //  try to catch exception if blank is inserted.
            //    assign month to the inserted month.
            //     if month inserted not in between 1 and 12 then set month to 0.
            while (month == 0)
            {
                Console.WriteLine("\nPlease enter the month...");

                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    if (month < 1 || month > 12)
                    {
                        Console.WriteLine("{0} is not a valid number of month, please re-enter the correct month...", month);
                        month = 0;
                    }
                    else
                        Console.WriteLine("You have entered {0} for month.", month);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            //add items to myStaff List - by using the file reader object (fr)
            // call the ReadFile method in FileReader Class. In there assign the result to myStaff.
            //  myStaff is a container containg the details of each staffs which was read froim the .txt file. There are 4 staffs in the file.
            myStaff =  fr.ReadFile();

            Console.WriteLine("\nThere are {0} staff read from the file staff.txt", myStaff.Count);
            
            //start to calculate the pay for each staff.
            // using For loop to go through each staff returned in myStaff List.
            for (int i = 0; i < myStaff.Count; i++)
            {
                try
                {
                    //prompt user to input Hours worked for specific Staf in the myStaff List.
                    Console.WriteLine("\n================= START ================= ");
                    Console.WriteLine("Please enter the hours worked for {0}:", myStaff[i].NameOfStaff);
                    //read the input and assign it to the Staff's HoursWorked property.
                    myStaff[i].HoursWorked = Convert.ToInt32(Console.ReadLine());
                    //now HoursWorked set we calculate the pay for this specific staff in the myStaff List
                    myStaff[i].CalculatePay();
                    //write the Staff toString to return all of the detail of current myStaff[i]
                    string displayToString = myStaff[i].ToString();
                    Console.WriteLine(displayToString);
                }
                catch (Exception e)
                {
                    //give error message
                    Console.WriteLine(e);
                    //if error occurred re-iterate i to -1 to revert the i value.
                    i--;
                }
            }

            //start of generating PaySlip for each staffs
            var ps = new PaySlip(month, year);
            //calling GeneratePaySlip from PaySlip Class, using List of Staff, as parameter 
            ps.GeneratePaySlip(myStaff);
            //calling GenerateSummary from PaySlip Class, using List of Staff, as parameter
            ps.GenerateSummary(myStaff);


            Console.ReadLine();
        }
        
        /*Console.WriteLine("Hello There!, welcome to the Payroll system");
        Console.WriteLine("___________________________________________");
        Console.ReadKey();

        var test1 = new Customers("Budong", 1);
        Console.WriteLine(test1.ToString());
        test1.orders.Add(new Order());
        test1.orders.Add(new Order());
        test1.orders.Add(new Order());

        Console.WriteLine(test1.orders.Count);


        //instantiate the object Staff1 from Staff Class.
        var staff1 = new Staff("Budong Drummond", 10);
        staff1.HoursWorked = 10;            
        Console.WriteLine(staff1.ToString());
        staff1.CalculatePay();

        Console.WriteLine("\n___________________________________________");
        Console.ReadKey();

        //instantiate the object manager1 from Manager Class - the child of Staff class.
        var manager1 = new Manager("Clare Carney");
        manager1.HoursWorked = 180;
        manager1.CalculatePay();
        Console.WriteLine(manager1.ToString());

        Console.WriteLine("\n___________________________________________");
        Console.ReadKey();

        //instantiate the object admin1 from Admin Class - the child of Staff class.
        var admin1 = new Admin("John Legend");
        admin1.HoursWorked = 170;
        admin1.CalculatePay();
        Console.WriteLine(admin1.ToString());

        Console.WriteLine("\n___________________________________________");
        Console.WriteLine("\n-----------Click any key to exit-----------");
        Console.ReadKey();
        */
    }
}